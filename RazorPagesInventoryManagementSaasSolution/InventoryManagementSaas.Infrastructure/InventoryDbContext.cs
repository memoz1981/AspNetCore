namespace InventoryManagementSaas.Infrastructure;

using Microsoft.EntityFrameworkCore;
using InventoryManagementSaas.Infrastructure.Entities;

public class InventoryDbContext : DbContext
{
    public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
    {}

    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Tenant> Tenants { get; set; }
}