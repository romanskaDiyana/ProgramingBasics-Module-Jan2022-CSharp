using System;

namespace _01NumbersEndingin7
{
    class Program
    {
        static void Main(string[] args)
        {
            //условие:
            //Напишете програма,
            //която отпечатва числата в диапазона
            //от 1 до 1000, които завършват на 7.

            //вход:

            for (int i = 7; i <= 997; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
