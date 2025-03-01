using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk_Razor_Pages.Data;
using MegaDesk_Razor_Pages.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk_Razor_Pages.Pages
{
    public class EditQuoteModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<EditQuoteModel> _logger;

        [BindProperty]
        public Quote Quote { get; set; }

        public EditQuoteModel(ApplicationDbContext context, ILogger<EditQuoteModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Quote = await _context.Quotes.FindAsync(id);
            if (Quote == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState)
                {
                    Console.WriteLine($"{error.Key}: {string.Join(", ", error.Value.Errors.Select(e => e.ErrorMessage))}");
                }
                return Page();
            }

            var existingQuote = await _context.Quotes.FindAsync(Quote.Id);
            if (existingQuote == null)
            {
                return NotFound();
            }

            _logger.LogInformation($"Before update: {existingQuote.CustomerName}, {existingQuote.QuoteTotal}");

            existingQuote.CustomerName = Quote.CustomerName;
            existingQuote.DeskWidth = Quote.DeskWidth;
            existingQuote.DeskDepth = Quote.DeskDepth;
            existingQuote.DeskMaterial = Quote.DeskMaterial;
            existingQuote.NumDrawers = Quote.NumDrawers;
            existingQuote.RushOrderDays = Quote.RushOrderDays;

            existingQuote.CalculatePrice();

            _logger.LogInformation($"After update: {existingQuote.CustomerName}, {existingQuote.QuoteTotal}");

            _context.Update(existingQuote);
            _logger.LogInformation("Updating the quote...");

            try
            {
                var result = await _context.SaveChangesAsync();
                _logger.LogInformation($"SaveChanges result: {result}");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error saving quote: {ex.Message}");
                throw;
            }

            return RedirectToPage("./ViewQuotes");
        }
    }
}
