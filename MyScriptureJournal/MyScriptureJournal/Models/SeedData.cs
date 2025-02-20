using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;
using MyScriptureJournal.Data;

namespace RazorPagesMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MyScriptureJournalContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MyScriptureJournalContext>>()))
        {
            if (context == null || context.Scripture == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            if (context.Scripture.Any())
            {
                return; 
            }

            context.Scripture.AddRange(
                new Scripture
                {
                    Title = "John",
                    Verse = "3:16",
                    DateAdded = DateTime.Parse("2025-01-01"),
                    Notes = "A powerful verse about God's love for mankind."
                },

                new Scripture
                {
                    Title = "Proverbs",
                    Verse = "3:5",
                    DateAdded = DateTime.Parse("2025-01-05"),
                    Notes = "A reminder to trust God in all things."
                },

                new Scripture
                {
                    Title = "Philippians",
                    Verse = "4:13",
                    DateAdded = DateTime.Parse("2025-01-10"),
                    Notes = "A verse of encouragement and strength."
                },

                new Scripture
                {
                    Title = "Matthew",
                    Verse = "11:28",
                    DateAdded = DateTime.Parse("2025-01-15"),
                    Notes = "A comforting invitation from Jesus."
                }
            );
            context.SaveChanges();
        }
    }
}
