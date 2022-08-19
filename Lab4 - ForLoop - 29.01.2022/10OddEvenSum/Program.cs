using System;

namespace _10OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход: Да се напише програма, която чете n-на брой цели числа

            
            int numberOfNumbers = int.Parse(Console.ReadLine());

            int sumEvenNumbersPossition = 0;
            int sumOddNumbersPossition = 0;
            //условие:
            //проверява дали сумата от числата на четни позиции е равна на сумата на числата на нечетни позиции. 
            for (int i = 0; i < numberOfNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEvenNumbersPossition += currentNumber;
                }
                else
                {
                    sumOddNumbersPossition += currentNumber;
                }
            }
            //изход:
            //Ако сумите са равни да се отпечатат два реда: "Yes" и на нов ред "Sum = " + сумата; 
            //Ако сумите не са равни да се отпечат два реда: "No" и на нов ред "Diff = " + разликата.
            //Разликата се изчислява по абсолютна стойност. 
            if (sumEvenNumbersPossition == sumOddNumbersPossition)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOddNumbersPossition}");
            }
            else 
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEvenNumbersPossition - sumOddNumbersPossition)}");
            }
        }
    }
}
