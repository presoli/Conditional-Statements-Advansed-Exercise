using System;

namespace Conditional_Statements_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerNum = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double flowerPrice = 0;
            
            if (flowerType == "Roses")
            {
                flowerPrice = 5;
               
                if (flowerNum > 80)
                {
                    flowerPrice *= 0.9;
                }
            }
            else if (flowerType == "Dahlias")
            {
                flowerPrice = 3.8;
                
                if (flowerNum > 90)
                {
                    flowerPrice *= 0.85;
                }
            }
            else if (flowerType == "Tulips")
            {
                flowerPrice = 2.8;
                
                if (flowerNum > 80)
                {
                    flowerPrice *= 0.85;
                }
            }
            else if (flowerType == "Narcissus")
            {
                flowerPrice = 3;
                
                if (flowerNum < 120)
                {
                    flowerPrice *= 1.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                flowerPrice = 2.5;
                
                if (flowerNum < 80)
                {
                    flowerPrice *= 1.2;
                }
            }
            double price = flowerNum * flowerPrice;

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerNum}" +
                    $" {flowerType} and {(budget - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(price - budget):f2} leva more.");
            }
        }
    }
}