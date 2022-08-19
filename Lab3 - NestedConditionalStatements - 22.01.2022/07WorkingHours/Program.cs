using System;

namespace _07WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = int.Parse(Console.ReadLine());
            string weekDay = Console.ReadLine();

            switch (weekDay)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    if (hour >= 10 && hour <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;

                case "Sunday":
                    Console.WriteLine("closed");
                    break;

            }
        }
    }
}
