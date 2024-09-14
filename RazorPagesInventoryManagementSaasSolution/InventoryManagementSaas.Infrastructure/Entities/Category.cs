namespace InventoryManagementSaas.Infrastructure.Entities;;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System; 
using System.Text.Json.Serialization;

[Table("Category", Schema = "dbo")]
public class Category
{
    [Key]
    public int CategoryId { get; set; }
    
    [Column("Name")]
    [DataType("nvarchar(30)")]
    [Required]
    public string Name { get; set; }
    
    [Column("Description")]
    [DataType("nvarchar(100)")]
    public string Description { get; set; }

    [JsonIgnore]
    public ICollection<Inventory> Inventories { get; set; }
}