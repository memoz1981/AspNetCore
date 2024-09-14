namespace InventoryManagementSaas.Infrastructure.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System; 
using System.Text.Json.Serialization;

[Table("Supplier", Schema = "dbo")]
public class Supplier
{
    [Key]
    public int SupplierId { get; set; }
    
    [Column("Name")]
    [DataType("nvarchar(30)")]
    [Required]
    public string Name { get; set; }
    
    [Column("PhoneNumber")]
    [DataType("nvarchar(30)")]
    public string PhoneNumber { get; set; }

    [Column("Email")]
    [DataType("nvarchar(30)")]
    public string Email { get; set; }

    [JsonIgnore]
    public ICollection<Inventory> Inventories { get; set; }
}
