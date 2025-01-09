using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{           


    internal class Program
    {
        static void Main(string[] args)
        {
        string name = "Brighton";
        string location = "Rexburg, ID";
        DateTime currentDate = DateTime.Today;
        

        Console.WriteLine($"My name is {name}.");
        Console.WriteLine($"I am living in {location}.");
        Console.WriteLine($"Today is {currentDate:MM/dd/yyyy}.");

        DateTime xmas = new DateTime(currentDate.Year, 12, 25);
        int daysUntilXmas = (xmas - currentDate).Days;

        Console.WriteLine($"There are {daysUntilXmas} days until Christmas.");

        double width, height, woodLength, glassArea;
        string widthString, heightString;

        Console.WriteLine("Please enter the width of the window frame");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        Console.WriteLine("Please enter the height of the window frame");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25;

        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
        Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        }
    }
}
