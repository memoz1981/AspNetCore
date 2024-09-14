using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryManagementSaas.Infrastructure;
using InventoryManagementSaas.Infrastructure.Entities;

namespace InventoryManagementSaas.RazorPages.Pages.Suppliers
{
    public class IndexModel : PageModel
    {
        private readonly InventoryManagementSaas.Infrastructure.InventoryDbContext _context;

        public IndexModel(InventoryManagementSaas.Infrastructure.InventoryDbContext context)
        {
            _context = context;
        }

        public IList<Supplier> Supplier { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Supplier = await _context.Suppliers.ToListAsync();
        }
    }
}
