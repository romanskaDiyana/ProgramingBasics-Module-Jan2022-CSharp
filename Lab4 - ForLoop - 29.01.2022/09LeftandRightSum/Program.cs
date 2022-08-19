using System;

namespace _09LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход: 
            int numberOfNumbers = int.Parse(Console.ReadLine());

            int sumOfNumbers1 = 0;
            int sumofNumbers2 = 0;
            //условие:
            //Да се напише програма, която чете 2 * n - на
            //брой цели числа, подадени от потребителя, и проверява дали
            //сумата на първите n числа(лява сума) е равна на сумата на вторите
            //n числа(дясна сума).
            for (int i = 0; i < numberOfNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                sumOfNumbers1 += currentNumber;
            }

            for (int i = 0; i < numberOfNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                sumofNumbers2 += currentNumber;
            }
            //При равенство печата " Yes, sum = " + сумата;
            //иначе печата " No, diff = " + разликата.Разликата се изчислява като
            //положително число(по абсолютна стойност).

            if (sumOfNumbers1 == sumofNumbers2)
            {
                Console.WriteLine($"Yes, sum = {sumOfNumbers1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumOfNumbers1- sumofNumbers2)}");
            }
        }
    }
}
