using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using aref_final.Data;
using aref_final.Models;

namespace aref_final.Pages.Toys
{
    public class IndexModel : PageModel
    {
        private readonly aref_final.Data.aref_finalContext _context;

        public IndexModel(aref_final.Data.aref_finalContext context)
        {
            _context = context;
        }

        public IList<Toy> Toy { get;set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Toy != null)
            {
                Toy = await _context.Toy.ToListAsync();
            }
        }
    }
}
