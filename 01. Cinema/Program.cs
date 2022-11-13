using System;

namespace Conditional_Statements_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double columns = double.Parse(Console.ReadLine());
            double income = 0;
            switch (type)
            {
                case "Premiere":
                    income = rows * columns * 12;
                    break;
                case "Normal":
                   income = rows * columns *7.5;
                    break;
                case "Discount":
                    income = rows * columns * 5;
                    break;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}