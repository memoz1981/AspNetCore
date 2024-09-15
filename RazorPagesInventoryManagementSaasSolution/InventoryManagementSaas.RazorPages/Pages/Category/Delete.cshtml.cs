using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InventoryManagementSaas.Service.Service.Categories;
using InventoryManagementSaas.Service.Dto;

namespace InventoryManagementSaas.RazorPages.Pages_Category
{
    public class DeleteModel : PageModel
    {
        private readonly ICategoryService _service;

        public DeleteModel(ICategoryService service)
        {
            _service = service;
        }

        [BindProperty]
        public CategoryExistingDto Category { get; set; } = default;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                var category = await _service.GetById(id.Value);  
                if (category == null)
                {
                    return NotFound();
                }
                else
                {
                    Category = category;
                }  
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message); 
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await _service.Delete(id.Value);

            return RedirectToPage("./Index");
        }
    }
}
