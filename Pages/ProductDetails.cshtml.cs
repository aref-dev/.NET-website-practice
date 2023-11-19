using aref_final.Data;
using aref_final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace aref_final.Pages
{
    public class ProductDetailsModel : PageModel
    {
        private readonly aref_finalContext _context;

        public ProductDetailsModel(aref_finalContext context)
        {
            _context = context;
        }

        public Toy Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Toy.FirstOrDefaultAsync(toy => toy.ID == id);

            if (Product == null)
            {
                return NotFound();
            }

			ViewData["Title"] = $"{Product.Name}";

			return Page();
        }
    }
}
