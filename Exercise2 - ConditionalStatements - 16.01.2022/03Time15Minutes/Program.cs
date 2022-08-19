using System;

namespace _03Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine()); // 23  час
            int minutes = int.Parse(Console.ReadLine()); // 50 мин

            int hoursInMinutes = minutes + hours * 60; // 50+23*60
            hoursInMinutes = hoursInMinutes + 15; // 65+23*60

            hours = hoursInMinutes / 60; // 24 мин
            minutes = hoursInMinutes % 60; // 5 мин

            if (hours ==24)
            {
                hours = 0; // 24-24 = 0
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else 
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}
