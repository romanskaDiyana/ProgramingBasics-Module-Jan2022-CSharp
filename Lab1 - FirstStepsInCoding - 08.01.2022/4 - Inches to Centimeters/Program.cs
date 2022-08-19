using System;

namespace _4___Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double centemmeters = inches * 2.54;

            Console.WriteLine(centemmeters);

        }
    }
}
