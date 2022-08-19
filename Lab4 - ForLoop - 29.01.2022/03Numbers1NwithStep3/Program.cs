using System;

namespace _03Numbers1NwithStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i+=3) //числата от 1 до n през 3 - започва от 1
            {
                Console.WriteLine(i);
            }


            int number1 = int.Parse(Console.ReadLine());

            int counter1 = 1;

            for (; counter1 <= number1;)
            {
                Console.WriteLine(counter1);
            }

            counter1 += 3;
        }
    }
}
