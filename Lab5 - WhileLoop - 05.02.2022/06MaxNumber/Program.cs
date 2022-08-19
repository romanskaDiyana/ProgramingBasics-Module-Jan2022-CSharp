using System;

namespace _06MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход:
            //Напишете програма, която до получаване на командата
            //"Stop", чете цели числа, въведени от
            //потребителя и намира най-голямото измежду тях.
            //Въвежда се по едно число на ред. 

            string command = Console.ReadLine();

            int maxNum = int.MinValue;

            while (command != "Stop")
            {
                int num = int.Parse(command);
               
                if (num > maxNum)
                {
                    maxNum = num;
                }

                command = Console.ReadLine();

            }

            Console.WriteLine(maxNum);
        }
    }
}
