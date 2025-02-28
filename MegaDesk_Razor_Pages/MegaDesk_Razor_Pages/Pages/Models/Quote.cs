namespace MegaDesk_Razor_Pages.Models
{
    public class Quote
    {
        public int Id { get; set; }  
        public string CustomerName { get; set; }
        public int DeskWidth { get; set; }
        public int DeskDepth { get; set; }
        public string DeskMaterial { get; set; }
        public int NumDrawers { get; set; }
        public int RushOrderDays { get; set; } 
        public decimal QuoteTotal { get; set; }
        public DateTime QuoteDate { get; set; } = DateTime.Now;

        public void CalculatePrice()
        {
            decimal totalPrice = 200; 


            int deskArea = DeskWidth * DeskDepth;
            if (deskArea > 1000)
            {
                totalPrice += deskArea - 1000; 
            }

            totalPrice += NumDrawers * 50; 

            switch (DeskMaterial)
            {
                case "Oak":
                    totalPrice += 200;
                    break;
                case "Laminate":
                    totalPrice += 100;
                    break;
                case "Pine":
                    totalPrice += 50;
                    break;
                case "Rosewood":
                    totalPrice += 300;
                    break;
                case "Veneer":
                    totalPrice += 125;
                    break;
            }

            totalPrice += GetRushOrderPrice(deskArea);

            QuoteTotal = totalPrice;
        }

        private decimal GetRushOrderPrice(int deskArea)
        {
            decimal rushOrderPrice = 0;

            if (RushOrderDays == 3)
            {
                if (deskArea < 1000)
                    rushOrderPrice = 60;
                else if (deskArea >= 1000 && deskArea <= 2000)
                    rushOrderPrice = 70;
                else
                    rushOrderPrice = 80;
            }
            else if (RushOrderDays == 5)
            {
                if (deskArea < 1000)
                    rushOrderPrice = 40;
                else if (deskArea >= 1000 && deskArea <= 2000)
                    rushOrderPrice = 50;
                else
                    rushOrderPrice = 60;
            }
            else if (RushOrderDays == 7)
            {
                if (deskArea < 1000)
                    rushOrderPrice = 30;
                else if (deskArea >= 1000 && deskArea <= 2000)
                    rushOrderPrice = 35;
                else
                    rushOrderPrice = 40;
            }

            return rushOrderPrice;
        }
    }
}
