using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; } 

        [BindProperty(SupportsGet = true)]
        public string? BookSearch { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SortOrder { get; set; }

        public async Task OnGetAsync()
        {
            // Initialize the query for filtering scriptures.
            var scriptures = from s in _context.Scripture
                             select s;

            // Apply the filter by SearchString (keyword in notes).
            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Notes.Contains(SearchString));
            }

            // Apply the filter by BookSearch (book name).
            if (!string.IsNullOrEmpty(BookSearch))
            {
                scriptures = scriptures.Where(s => s.Title.ToLower().Contains(BookSearch.ToLower()));
            }


            // Handle sorting by SortOrder (by book or by date).
            switch (SortOrder)
            {
                case "book":
                    scriptures = scriptures.OrderBy(s => s.Title);  // Sort by book name
                    break;
                case "date":
                    scriptures = scriptures.OrderBy(s => s.DateAdded);  // Sort by date added
                    break;
                default:
                    scriptures = scriptures.OrderBy(s => s.Title);  // Default sort by book
                    break;
            }

            // Execute the query and store the results.
            Scripture = await scriptures.ToListAsync();
        }
    }
}
