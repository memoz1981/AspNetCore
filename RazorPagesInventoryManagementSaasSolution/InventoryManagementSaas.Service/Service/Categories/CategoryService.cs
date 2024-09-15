using AutoMapper;
using InventoryManagementSaas.Infrastructure;
using InventoryManagementSaas.Infrastructure.Entities;
using InventoryManagementSaas.Service.Dto;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSaas.Service.Service.Categories; 

public interface ICategoryService
{
    IAsyncEnumerable<CategoryExistingDto> GetAll(); 

    Task<CategoryExistingDto> GetById(int categoryId);

    Task<int> Add(CategoryNewDto category); 

    Task Update(CategoryExistingDto category); 

    Task Delete(int id); 
}

public class CategoryService : ICategoryService
{
    private readonly InventoryDbContext _context;
    private readonly IMapper _mapper;

    public CategoryService(InventoryDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Add(CategoryNewDto category)
    {
        //validation
        var doesExist = _context.Categories
            .Any(cat => cat.Name == category.Name);

        if(doesExist)
            throw new ArgumentException($"Category with the name {category.Name} already exists.");
        
        var entity = _mapper.Map<Category>(category); 
        
        await _context.Categories.AddAsync(entity); 
        await _context.SaveChangesAsync(); 

        return entity.CategoryId; 
    }

    public async Task Delete(int id)
    {
        //validation
        var entity = await _context.Categories
            .FirstOrDefaultAsync(cat => cat.CategoryId == id);

        if(entity is null)
            throw new ArgumentException($"Category with the CategoryId {id} doesn't exist.");
        
        _context.Categories.Remove(entity); 
        await _context.SaveChangesAsync(); 
    }

    public async IAsyncEnumerable<CategoryExistingDto> GetAll()
    {
        await foreach (var entity in _context.Categories.AsAsyncEnumerable())
        {
            yield return _mapper.Map<CategoryExistingDto>(entity);
        }
    }

    public async Task<CategoryExistingDto> GetById(int categoryId)
    {
        var entity =  await _context.Categories
        .FirstOrDefaultAsync(cat => cat.CategoryId == categoryId);

        return _mapper.Map<CategoryExistingDto>(entity); 
    }

    public async Task Update(CategoryExistingDto category)
    {
        //validation - by category id
        var doesExist = _context.Categories
            .Any(cat => cat.CategoryId == category.CategoryId);

        if(!doesExist)
            throw new ArgumentException($"Category with the CategoryId {category.CategoryId} doesn't exist.");
        
        //validation - by category name
        var anyCatWithNewNameExists = _context.Categories
            .Any(cat => cat.CategoryId != category.CategoryId
            && cat.Name == category.Name);
        
         if(anyCatWithNewNameExists)
            throw new ArgumentException($"Category with the name {category.Name} already exists.");

        var entity = _mapper.Map<Category>(category); 
        _context.Categories.Update(entity); 
        await _context.SaveChangesAsync(); 
    }
}