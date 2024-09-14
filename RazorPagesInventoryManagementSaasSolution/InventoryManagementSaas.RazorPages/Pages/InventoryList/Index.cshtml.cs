using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryManagementSaas.Infrastructure;
using InventoryManagementSaas.Infrastructure.Entities;

namespace InventoryManagementSaas.RazorPages.Pages.InventoryList
{
    public class IndexModel : PageModel
    {
        private readonly InventoryManagementSaas.Infrastructure.InventoryDbContext _context;

        public IndexModel(InventoryManagementSaas.Infrastructure.InventoryDbContext context)
        {
            _context = context;
        }

        public IList<Inventory> Inventory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Inventory = await _context.Inventories
                .Include(i => i.Category)
                .Include(i => i.Supplier).ToListAsync();
        }
    }
}
