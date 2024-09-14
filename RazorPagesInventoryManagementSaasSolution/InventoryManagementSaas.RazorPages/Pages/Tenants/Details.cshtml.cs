using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryManagementSaas.Infrastructure;
using InventoryManagementSaas.Infrastructure.Entities;

namespace InventoryManagementSaas.RazorPages.Pages.Tenants
{
    public class DetailsModel : PageModel
    {
        private readonly InventoryManagementSaas.Infrastructure.InventoryDbContext _context;

        public DetailsModel(InventoryManagementSaas.Infrastructure.InventoryDbContext context)
        {
            _context = context;
        }

        public Tenant Tenant { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tenant = await _context.Tenants.FirstOrDefaultAsync(m => m.TenantId == id);
            if (tenant == null)
            {
                return NotFound();
            }
            else
            {
                Tenant = tenant;
            }
            return Page();
        }
    }
}
