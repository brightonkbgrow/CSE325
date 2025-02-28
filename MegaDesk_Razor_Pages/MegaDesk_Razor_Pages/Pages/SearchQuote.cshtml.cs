using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MegaDesk_Razor_Pages.Data;
using MegaDesk_Razor_Pages.Models;
using System.Collections.Generic;
using System.Linq;

namespace MegaDesk_Razor_Pages.Pages
{
    public class SearchQuoteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public SearchQuoteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public List<Quote> Quotes { get; set; } = new();

        public void OnGet()
        {
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                Quotes = _context.Quotes
                    .Where(q => q.CustomerName.Contains(SearchTerm))
                    .ToList();
            }
        }
    }
}
