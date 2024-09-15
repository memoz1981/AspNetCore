using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InventoryManagementSaas.Service.Service.Categories;
using InventoryManagementSaas.Service.Dto;

namespace InventoryManagementSaas.RazorPages.Pages_Category
{
    public class CreateModel : PageModel
    {
        private readonly ICategoryService _service; 

        public CreateModel(ICategoryService service)
        {
            _service = service;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CategoryNewDto Category { get; set; } = default;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                await _service.Add(Category);      
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message); 
            }

            return RedirectToPage("./Index");
        }
    }
}
