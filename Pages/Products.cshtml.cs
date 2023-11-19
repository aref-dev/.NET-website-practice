using aref_final.Data;
using aref_final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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

		public async Task OnGetAsync()
        {
            Toys = _context.Toy.ToList();
        }
    }
}
