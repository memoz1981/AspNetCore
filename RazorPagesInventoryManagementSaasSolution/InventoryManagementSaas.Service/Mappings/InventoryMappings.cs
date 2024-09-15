namespace InventoryManagementSaas.Service.Mappings;

using AutoMapper;
using InventoryManagementSaas.Infrastructure.Entities;
using InventoryManagementSaas.Service.Dto;

public class InventoryMappings : Profile
{
    public InventoryMappings() : base()
    {
        //Category
        CreateMap<Category, CategoryNewDto>().ReverseMap();
        CreateMap<Category, CategoryExistingDto>().ReverseMap(); 
    }
}