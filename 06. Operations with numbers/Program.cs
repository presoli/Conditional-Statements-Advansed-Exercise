using System;

namespace Conditional_Statements_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            char action = char.Parse(Console.ReadLine());

            if (action == '+')
            {
                Console.Write($"{firstNum} + {secondNum} = {firstNum + secondNum}");
                if ((firstNum + secondNum) % 2 == 0)
                {
                    Console.Write(" - even");
                }
                else
                {
                    Console.Write(" - odd");
                }
            }
            else if (action == '-')
            {
                Console.Write($"{firstNum} - {secondNum} = {firstNum - secondNum}");
                if ((firstNum - secondNum) % 2 == 0)
                {
                    Console.Write(" - even");
                }
                else
                {
                    Console.Write(" - odd");
                }
            }
            else if (action == '*')
            {
                Console.Write($"{firstNum} * {secondNum} = {firstNum * secondNum}");
                if ((firstNum * secondNum) % 2 == 0)
                {
                    Console.Write(" - even");
                }
                else
                {
                    Console.Write(" - odd");
                }
            }
            else if (action == '/')
            {
                if (secondNum != 0)
                {
                    Console.WriteLine($"{firstNum} / {secondNum} = {(firstNum / secondNum):f2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {firstNum} by zero");
                }
            }
            else
            {
                if (secondNum != 0)
                {
                    Console.WriteLine($"{firstNum} % {secondNum} = {firstNum % secondNum}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {firstNum} by zero");
                }
            }
        }
    }
}