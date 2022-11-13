using System;

namespace Conditional_Statements_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            string destination = "";
            string place = "";

            if (season == "summer")
            {
                place = "Camp";
            }
            else
            {
                place = "Hotel";
            }

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    price = budget * 0.3;
                }
                else
                {
                    price = budget * 0.7;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    price = budget * 0.4;
                }
                else
                {
                    price = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                price = budget * 0.9;
                place = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {price:f2}");
        }
    }
}