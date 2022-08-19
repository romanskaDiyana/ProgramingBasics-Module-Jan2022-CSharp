using System;

namespace _02EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            //условие:
            //Напишете програма, която чете от конзолата две шестцифрени цели
            //числа в диапазона от 100000 до 300000. Винаги първото въведено
            //число ще бъде по малко от второто. На конзолата да се отпечатат на
            //1 ред разделени с интервал всички числа, които се намират между
            //двете, прочетени от конзолата числа и отговарят на следното условие:

            //Сумата от цифрите на четни и нечетни позиции да са равни.
            //Ако няма числа, отговарящи на условието на конзолата не се
            //извежда резултат.

            int num1 = int.Parse(Console.ReadLine()); // 6 цифрено число
            int num2 = int.Parse(Console.ReadLine());

            int sumOdd;
            int sumEven;

            for (int i = num1; i <= num2; i++)
            {
                sumOdd = 0;
                sumEven = 0;

                string currentNum = i.ToString(); //работим със string, за да вземем ПОЗИЦИЯТА НА ЧИСЛОТО, а не самото число

                for (int lenghtNum = 0; lenghtNum < currentNum.Length; lenghtNum++)
                {
                    if (lenghtNum % 2 == 0)
                    {
                        sumEven += currentNum[lenghtNum];
                    }
                    else 
                    {
                        sumOdd += currentNum[lenghtNum];
                    }
                }

                if (sumOdd == sumEven)
                {
                    Console.Write(currentNum + " "); // Write - на 1 ред с интервал 
                }
            }
        }
    }
}
