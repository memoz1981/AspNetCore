namespace InventoryManagementSaas.Infrastructure.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System; 

[Table("Company", Schema = "dbo")]
public class Company
{
    [Key]
    public int CompanyId { get; set; }
    
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
}