namespace InventoryManagementSaas.Service.Dto;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System; 
using System.Text.Json.Serialization;

public class CategoryNewDto
{
    public string Name { get; set; }
    
    public string Description { get; set; }
}

public class CategoryExistingDto
{
    public int CategoryId { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
}