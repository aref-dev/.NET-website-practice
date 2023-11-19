using aref_final.Data;
using aref_final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace aref_final.Pages
{
    public class SearchModel : PageModel
    {
        private readonly aref_finalContext _context;

        public SearchModel(aref_finalContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public List<Toy> SearchResults { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            if (string.IsNullOrEmpty(SearchTerm))
            {
                return Page();
            }

            // Search by name or category (modify as needed)
            SearchResults = await _context.Toy
                .Where(p => EF.Functions.Like(p.Name, $"%{SearchTerm}%") || EF.Functions.Like(p.Category, $"%{SearchTerm}%"))
                .ToListAsync();

            ViewData["Title"] = $"Search Results for '{SearchTerm}'";

            return Page();
        }
    }
}
