using System;

namespace Conditional_Statements_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int ExamTime = hour * 60 + minute;
            int ArrivalTime = arrivalHour * 60 + arrivalMinute;

            string type = "before"; //is the participant late or early

            switch (ExamTime - ArrivalTime)
            {
                case < 0:
                    Console.WriteLine("Late");
                    type = "after";
                    break;
                case >= 0 and <= 30:
                    Console.WriteLine("On time");
                    break;
                case > 30:
                    Console.WriteLine("Early");
                    break;
            }
            int absTime = Math.Abs(ExamTime - ArrivalTime);

            switch (absTime)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine($"1 minute {type} the start");
                    break;
                case > 1 and < 60:
                    Console.WriteLine($"{absTime} minutes {type} the start");
                    break;
                default:
                    Console.WriteLine($"{absTime / 60}:{absTime % 60:d2} hours {type} the start");
                    break;
            }
        }
    }
}