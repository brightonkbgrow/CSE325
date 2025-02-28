using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MegaDesk_Razor_Pages.Data;
using MegaDesk_Razor_Pages.Models;
using System.Threading.Tasks;

namespace MegaDesk_Razor_Pages.Pages
{
    public class DeleteQuoteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteQuoteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Quote Quote { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Quote = await _context.Quotes.FindAsync(id);
            if (Quote == null) return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var quote = await _context.Quotes.FindAsync(id);

            if (quote != null)
            {
                _context.Quotes.Remove(quote);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./ViewQuotes");
        }
    }
}
