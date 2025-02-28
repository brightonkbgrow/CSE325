using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk_Razor_Pages.Data;
using MegaDesk_Razor_Pages.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MegaDesk_Razor_Pages.Pages
{
    public class ViewQuotesModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ViewQuotesModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Quote> Quotes { get; set; }

        public async Task OnGetAsync()
        {
            Quotes = await _context.Quotes.ToListAsync();
        }
    }
}
