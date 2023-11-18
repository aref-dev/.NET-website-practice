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
    public class DeleteModel : PageModel
    {
        private readonly aref_final.Data.aref_finalContext _context;

        public DeleteModel(aref_final.Data.aref_finalContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Toy Toy { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Toy == null)
            {
                return NotFound();
            }

            var toy = await _context.Toy.FirstOrDefaultAsync(m => m.ID == id);

            if (toy == null)
            {
                return NotFound();
            }
            else 
            {
                Toy = toy;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Toy == null)
            {
                return NotFound();
            }
            var toy = await _context.Toy.FindAsync(id);

            if (toy != null)
            {
                Toy = toy;
                _context.Toy.Remove(Toy);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
