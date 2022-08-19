using System;

namespace _04Even_owersof2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int counter = 0; counter <= number; counter+=2)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(2, counter));
                }
            }




            int counterStart = int.Parse(Console.ReadLine());

            int counterEnd = 0;

            for (; counterEnd <= counterStart;)
            {
                if (counterEnd % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(2, counterEnd));
                }
                
            }
            counterEnd++;



        }
    }
}
