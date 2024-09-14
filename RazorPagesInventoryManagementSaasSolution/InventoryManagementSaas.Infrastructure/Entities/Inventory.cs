namespace InventoryManagementSaas.Infrastructure.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System; 

[Table("Inventory", Schema = "dbo")]
public class Inventory
{
    [Key]
    public int InventoryId { get; set; }
    
    [Column("Name")]
    [DataType("nvarchar(30)")]
    [Required]
    public string Name { get; set; }
    
    [Column("Description")]
    [DataType("nvarchar(100)")]
    public string Description { get; set; }
    
    [Column("QuantityInStock")]
    public int QuantityInStock { get; set; }
    
    [Column("ReorderLevel")]
    public int ReorderLevel { get; set; }
    
    [Column("UnitPrice")]
    public decimal UnitPrice { get; set; }
    
    [Column("CategoryId")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    [Column("SupplierId")]
    public int SupplierId { get; set; }
    public Supplier Supplier { get;set; }
}