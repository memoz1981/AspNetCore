using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InventoryManagementSaas.Service.Service.Categories;
using InventoryManagementSaas.Service.Dto;

namespace InventoryManagementSaas.RazorPages.Pages_Category
{
    public class DetailsModel : PageModel
    {
        private readonly ICategoryService _service;

        public DetailsModel(ICategoryService service)
        {
            _service = service; 
        }

        public CategoryExistingDto Category { get; set; } = default;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _service.GetById(id.Value);
            if (category == null)
            {
                return NotFound();
            }
            else
            {
                Category = category;
            }
            return Page();
        }
    }
}
