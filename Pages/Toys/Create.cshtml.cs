using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using aref_final.Data;
using aref_final.Models;

namespace aref_final.Pages.Toys
{
    public class CreateModel : PageModel
    {
        private readonly aref_final.Data.aref_finalContext _context;

        public CreateModel(aref_final.Data.aref_finalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Toy Toy { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Toy == null || Toy == null)
            {
                return Page();
            }

            _context.Toy.Add(Toy);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
