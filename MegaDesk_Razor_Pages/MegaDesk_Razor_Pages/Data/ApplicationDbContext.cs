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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Quote Table with sample data
            modelBuilder.Entity<Quote>().HasData(
                new Quote
                {
                    Id = 1,
                    CustomerName = "John Doe",
                    DeskWidth = 60,
                    DeskDepth = 30,
                    DeskMaterial = "Oak",
                    NumDrawers = 2,
                    RushOrderDays = 3,
                    QuoteDate = DateTime.Now,
                    QuoteTotal = 1200
                },
                new Quote
                {
                    Id = 2,
                    CustomerName = "Jane Smith",
                    DeskWidth = 72,
                    DeskDepth = 36,
                    DeskMaterial = "Laminate",
                    NumDrawers = 4,
                    RushOrderDays = 5,
                    QuoteDate = DateTime.Now,
                    QuoteTotal = 1500
                },
                new Quote
                {
                    Id = 3,
                    CustomerName = "Alice Johnson",
                    DeskWidth = 48,
                    DeskDepth = 24,
                    DeskMaterial = "Pine",
                    NumDrawers = 3,
                    RushOrderDays = 7,
                    QuoteDate = DateTime.Now.AddDays(-1),
                    QuoteTotal = 1100
                },
                new Quote
                {
                    Id = 4,
                    CustomerName = "Bob Brown",
                    DeskWidth = 60,
                    DeskDepth = 30,
                    DeskMaterial = "Veneer",
                    NumDrawers = 2,
                    RushOrderDays = 0,
                    QuoteDate = DateTime.Now.AddDays(-2),
                    QuoteTotal = 1000
                }
            );
        }
    }
}