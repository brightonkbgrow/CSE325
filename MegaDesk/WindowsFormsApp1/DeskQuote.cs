using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaDesk_Grow;
namespace MegaDesk_Grow
{
    public class DeskQuote
    {
        public Desk Desk { get; set; }
        public string CustomerName { get; set; }
        public int RushDays { get; set; }
        public DateTime QuoteDate { get; set; }
        public decimal QuoteTotal { get; set; }

        public DeskQuote(Desk desk, string customerName, int rushDays, DateTime quoteDate)
        {
            Desk = desk;
            CustomerName = customerName;
            RushDays = rushDays;
            QuoteDate = quoteDate;

            CalculateQuoteTotal();
        }

        private void CalculateQuoteTotal()
        {
            decimal basePrice = 200; 
            decimal widthFactor = 0.5m; 
            decimal depthFactor = 0.3m;
            decimal drawerFactor = 50;
            decimal rushFactor = RushDays == 3 ? 1.2m : RushDays == 5 ? 1.1m : 1.0m; 


            QuoteTotal = basePrice + (Desk.Width * widthFactor) + (Desk.Depth * depthFactor)
                         + (Desk.NumberOfDrawers * drawerFactor);

            QuoteTotal *= rushFactor;
        }

        public void DisplayQuoteDetails()
        {
            Console.WriteLine($"Customer: {CustomerName}");
            Console.WriteLine($"Desk Width: {Desk.Width} inches");
            Console.WriteLine($"Desk Depth: {Desk.Depth} inches");
            Console.WriteLine($"Number of Drawers: {Desk.NumberOfDrawers}");
            Console.WriteLine($"Material: {Desk.Material}");
            Console.WriteLine($"Rush Days: {RushDays}");
            Console.WriteLine($"Quote Date: {QuoteDate.ToShortDateString()}");
            Console.WriteLine($"Total Quote: ${QuoteTotal:F2}");
        }
    }
}