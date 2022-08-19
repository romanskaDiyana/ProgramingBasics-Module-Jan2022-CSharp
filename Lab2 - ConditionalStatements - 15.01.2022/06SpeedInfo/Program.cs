using System;

namespace _06SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // четем - реално число 

            double speed = double.Parse(Console.ReadLine());

            // залагаме ако:
            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            if (speed > 10 && speed <= 50)
            {
                Console.WriteLine("average");
            }
            if (speed > 50 && speed <= 150)
            {
                Console.WriteLine("fast");
            }
            if (speed > 150 && speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            if (speed > 1000)
            {
                Console.WriteLine("extremely fast");
            }
        }

    }
}     
