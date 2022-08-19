using System;

namespace _2___Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем radians 
            double radians = double.Parse(Console.ReadLine());

            //преобразуваме radians -> degrees
            //формула: degrees =  radians * 180 / π =>  π = Math.PI)
            double degrees = radians * 180 / Math.PI;

            //отпечатваме result (degrees)

            Console.WriteLine(degrees);
        }
    }
}
