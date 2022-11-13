using System;

namespace Conditional_Statements_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            int nights = days - 1;
            int priceNight = 0;
            double[,] discount = { { 1, 0.7, 0.9 }, { 1, 0.65, 0.85 }, { 1, 0.5, 0.8 } };
            int x = 0;
            int y = 0;
            if (days < 10)
            {
                x = 0;
            }
            else if (days >= 10 && days <= 15)
            {
                x = 1;
            }
            else
            {
                x = 2;
            }

            switch (roomType)
            {
                case "room for one person":
                    y = 0;
                    priceNight = 18;
                    break;
                case "apartment":
                    y = 1;
                    priceNight = 25;
                    break;
                case "president apartment":
                    y = 2;
                    priceNight = 35;
                    break;
            }
            double price = nights * priceNight;
            price *= discount[x, y];

            if (rating == "positive")
            {
                price *= 1.25;
            }
            else
            {
                price *= 0.9;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}