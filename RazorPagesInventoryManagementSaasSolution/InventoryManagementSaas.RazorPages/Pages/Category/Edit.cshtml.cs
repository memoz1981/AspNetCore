using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InventoryManagementSaas.Service.Service.Categories;
using InventoryManagementSaas.Service.Dto;

namespace InventoryManagementSaas.RazorPages.Pages_Category
{
    public class EditModel : PageModel
    {
        private readonly ICategoryService _service;

        public EditModel(ICategoryService service)
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

            var category =  await _service.GetById(id.Value);
            if (category == null)
            {
                return NotFound();
            }
            Category = category;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                await _service.Update(Category); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }

            return RedirectToPage("./Index");
        }
    }
}
