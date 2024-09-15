using Microsoft.AspNetCore.Mvc.RazorPages;
using InventoryManagementSaas.Service.Service.Categories;
using InventoryManagementSaas.Service.Dto;

namespace InventoryManagementSaas.RazorPages.Pages_Category
{
    public class IndexModel : PageModel
    {
        private readonly ICategoryService _service;

        public IndexModel(ICategoryService service)
        {
            _service = service; 
        }

        public IList<CategoryExistingDto> Categories { get;set; } = new List<CategoryExistingDto>();

        public async Task OnGetAsync()
        {
            await foreach(var item in _service.GetAll())
                Categories.Add(item); 
        }
    }
}
