using Microsoft.AspNetCore.Mvc.RazorPages;
using MegaDesk_Razor_Pages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using MegaDesk_Razor_Pages.Data;

namespace MegaDesk_Razor_Pages.Pages
{
    public class ViewQuotesModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ViewQuotesModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Quote> Quotes { get; set; }
        public string SortOrder { get; set; }

        public string CustomerNameSearch { get; set; }
        public string DeskMaterialSearch { get; set; }

        public void OnGet(string sortOrder, string customerNameSearch, string deskMaterialSearch)
        {
            SortOrder = sortOrder;

            var quotes = _context.Quotes.AsQueryable();

            if (!string.IsNullOrEmpty(customerNameSearch))
            {
                quotes = quotes.Where(q => q.CustomerName.Contains(customerNameSearch));
            }

            if (!string.IsNullOrEmpty(deskMaterialSearch))
            {
                quotes = quotes.Where(q => q.DeskMaterial.Contains(deskMaterialSearch));
            }

            switch (SortOrder)
            {
                case "CustomerName":
                    quotes = quotes.OrderBy(q => q.CustomerName);
                    break;

                case "Date":
                default:
                    quotes = quotes.OrderBy(q => q.QuoteDate);
                    break;
            }

            Quotes = quotes.ToList();
        }
    }
}
