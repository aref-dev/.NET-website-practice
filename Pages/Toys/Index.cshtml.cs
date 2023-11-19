using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aref_final.Data;
using aref_final.Models;
using NuGet.Frameworks;

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
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Categories { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ToyCategory { get; set; }
        public async Task OnGetAsync()
        {
            IQueryable<string> categoryQuery = from t in _context.Toy
                                            orderby t.Category
                                            select t.Category;
            var toy = from t in _context.Toy
                      select t;

            if (!string.IsNullOrEmpty(SearchString))
            {
                toy = toy.Where(s => s.Category.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(ToyCategory))
            {
                toy = toy.Where(x => x.Category == ToyCategory);
            }

            Categories = new SelectList(await categoryQuery.Distinct().ToListAsync());   
            Toy = await toy.ToListAsync();


        }

        
    }
}
