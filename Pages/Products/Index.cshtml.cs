using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Homework6.Models;

namespace Homework6.Pages_Products
{
    public class IndexModel : PageModel
    {
        private readonly Homework6.Models.AppDbContext _context;

        public IndexModel(Homework6.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.Include(p => p.Reviews).ToListAsync();
        }
    }
}
