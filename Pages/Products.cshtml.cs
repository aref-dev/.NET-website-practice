using aref_final.Data;
using aref_final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace aref_final.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly aref_finalContext _context;

        public ProductsModel(aref_finalContext context)
        {
            _context = context;
        }

		public IList<Toy> Toys { get; set; }

		public async Task OnGetAsync(string category)
        {
            IQueryable<Toy> toysQuery = _context.Toy;

            if (!string.IsNullOrEmpty(category))
            {
                toysQuery = toysQuery.Where(toy => toy.Category == category);
            }

            Toys = await toysQuery.ToListAsync();
        }
    }
}
