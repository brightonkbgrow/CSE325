using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MegaDesk_Razor_Pages.Models;
using MegaDesk_Razor_Pages.Data;

namespace MegaDesk_Razor_Pages.Pages
{
    public class AddQuoteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public AddQuoteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Quote Quote { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Quote.CalculatePrice();

            _context.Quotes.Add(Quote);
            _context.SaveChanges();

            return RedirectToPage("./ViewQuotes");
        }
    }
}
