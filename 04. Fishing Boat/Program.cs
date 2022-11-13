using System;

namespace Conditional_Statements_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double lease = 0;

            if (season == "Spring")
            {
                lease = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                lease = 4200;
            }
            else if (season == "Winter")
            {
                lease = 2600;
            }

            if (fishermen <= 6)
            {
                lease *= 0.90;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                lease *= 0.85;
            }
            else if (fishermen >= 12)
            {
                lease *= 0.75;
            }
            if (fishermen % 2 == 0 && season != "Autumn")
            {
                lease *= 0.95;
            }

            if (budget >= lease)
            {
                Console.WriteLine($"Yes! You have {budget - lease:f2} leva left.");
            }
            else if (lease > budget)
            {
                Console.WriteLine($"Not enough money! You need {lease - budget:f2} leva.");
            }
        }
    }
}