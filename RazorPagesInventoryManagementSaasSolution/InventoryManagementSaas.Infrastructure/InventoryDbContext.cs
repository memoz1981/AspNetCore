namespace InventoryManagementSaas.Infrastructure;

using Microsoft.EntityFrameworkCore;

public class InventoryDbContext : DbContext
{
    public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
    {}

    public DbSet<Inventory> Inventories { get; }
    public DbSet<Category> Categories { get; }
    public DbSet<Company> Companies { get; }
    public DbSet<Supplier> Suppliers { get; }
    public DbSet<Tenant> Tenants { get; set; }
}