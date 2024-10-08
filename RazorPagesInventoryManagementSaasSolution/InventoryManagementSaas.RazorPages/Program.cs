using Microsoft.EntityFrameworkCore;
using InventoryManagementSaas.Infrastructure;
using InventoryManagementSaas.Service.Service.Categories;
using InventoryManagementSaas.Service.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<InventoryDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Inventory")));

builder.Services.AddAutoMapper(m => m.AddProfile<InventoryMappings>()); 
//Services
builder.Services.AddScoped<ICategoryService, CategoryService>(); 


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
