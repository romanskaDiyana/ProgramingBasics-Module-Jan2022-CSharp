using System;

namespace _07MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход:

            //Напишете програма, която до получаване на командата "Stop",
            //чете цели числа, въведени от потребителя и намира
            //най-малкото измежду тях. Въвежда се по едно число на ред.

            string command = Console.ReadLine();

            int minNum = int.MaxValue;

            while (command != "Stop")
            {
                int num = int.Parse(command);

                if (num < minNum)
                {
                    minNum = num;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(minNum);

        }
    }
}
