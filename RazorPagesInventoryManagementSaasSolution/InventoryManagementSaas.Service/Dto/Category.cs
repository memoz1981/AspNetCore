namespace InventoryManagementSaas.Service.Dto;

public class CategoryNewDto
{
    public string Name { get; set; }
    
    public string Description { get; set; }
}

public class CategoryExistingDto : CategoryNewDto
{
    public int CategoryId { get; set; }
}