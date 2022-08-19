using System;

namespace _04Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход:
            //Напишете програма, която чете число n, въведено от потребителя,
            //и отпечатва всички числа ≤ n от редицата: 1, 3, 7, 15, 31, ….
            //Всяко следващо число се изчислява като умножим
            //предишното с 2 и добавим 1.

            int num = int.Parse(Console.ReadLine());

            int counterForWhile = 1;

            while (counterForWhile <= num)
            {
                Console.WriteLine(counterForWhile);
                counterForWhile = counterForWhile * 2 + 1;
            }
        }
    }
}
