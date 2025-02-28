using Microsoft.EntityFrameworkCore;
using MegaDesk_Razor_Pages.Models;
using System.Collections.Generic;
using MegaDesk_Razor_Pages.Data;

namespace MegaDesk_Razor_Pages.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=MegaDeskDB;Trusted_Connection=True;MultipleActiveResultSets=true",
                sqlServerOptionsAction: sqlOptions => sqlOptions.EnableRetryOnFailure()
            );
        }
    }
}