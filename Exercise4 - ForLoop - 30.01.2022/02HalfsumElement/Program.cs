using System;

namespace _02HalfsumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход:
            //Да се напише програма, която чете n-на брой цели числа, въведени от потребителя:


            int numberOfNUmbers = int.Parse(Console.ReadLine());

            int sumNumbers = 0;
            int maxNum = int.MinValue;

            //условие:проверява дали сред тях съществува число, което е равно на сумата на всички останали. 

            for (int i = 1; i <= numberOfNUmbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sumNumbers += currentNumber;

                if (currentNumber > maxNum)
                {
                    maxNum = currentNumber; 
                }               
            }

            //изход:
            //Ако има такъв елемент печата "Yes" и на нов ред "Sum = "  + неговата стойност
            //Ако няма такъв елемент печата "No" и на нов ред "Diff = " + разликата между най-големия елемент и сумата на останалите(по абсолютна стойност)
            sumNumbers = sumNumbers - maxNum;
            if (sumNumbers == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum - sumNumbers)}");
            }
        }
    }
}
