using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk_Razor_Pages.Data;
using MegaDesk_Razor_Pages.Models;
using System.Threading.Tasks;

namespace MegaDesk_Razor_Pages.Pages
{
    public class EditQuoteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Quote Quote { get; set; }

        public EditQuoteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Quote = await _context.Quotes.FindAsync(id);
            if (Quote == null) return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            _context.Attach(Quote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuoteExists(Quote.Id)) return NotFound();
                else throw;
            }

            return RedirectToPage("./ViewQuotes");
        }

        private bool QuoteExists(int id)
        {
            return _context.Quotes.Any(e => e.Id == id);
        }
    }
}
