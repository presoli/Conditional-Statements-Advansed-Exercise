using System;

namespace Conditional_Statements_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double flatPrice = 0;
            double studioPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    flatPrice = 65 * nights;
                    studioPrice = 50 * nights;
                    if (nights > 7 && nights <= 14)
                    {
                        studioPrice *= 0.9;
                    }
                    else if (nights > 14)
                    {
                        studioPrice *= 0.7;
                    }
                    break;
                case "June":
                case "September":
                    flatPrice = 68.7 * nights;
                    studioPrice = 75.2 * nights;
                    if (nights > 14)
                    {
                        studioPrice *= 0.8;
                    }
                    break;

                case "July":
                case "August":
                    flatPrice = 77 * nights;
                    studioPrice = 76 * nights;
                    break;
            }
            if (nights > 14)
            {
                flatPrice *= 0.9;
            }
            Console.WriteLine($"Apartment: {flatPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}