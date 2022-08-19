using System;

namespace _02MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {

            int result = 0;

            for (int number = 1; number <= 10; number++)
            {
                for (int number2 = 1; number2 <= 10; number2++)
                {
                    result = number * number2;
                    Console.WriteLine($"{number} * {number2} = {result}");
                }

               // 10*10 - 100 итерации;
            }
        }
    }
}
