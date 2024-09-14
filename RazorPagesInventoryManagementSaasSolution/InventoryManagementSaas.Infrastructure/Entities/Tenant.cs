namespace InventoryManagementSaas.Infrastructure.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System; 

[Table("Tenant", Schema = "dbo")]
public class Tenant
{
    [Key]
    public int TenantId { get; set; }

    [Required]
    [DataType("nvarchar(30)")]
    [Column("Name")]
    public int Name { get; set; }

    [Required]
    [DataType("nvarchar(30)")]
    [Column("Host")]
    public int Host { get; set; }
}