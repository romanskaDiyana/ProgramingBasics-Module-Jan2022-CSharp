using System;

namespace _04SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //условие:Напишете програма която проверява всички възможни
            //комбинации от двойка числа в интервала от две дадени числа.
            //На изхода се отпечатва, коя поред е комбинацията чиито сбор
            //от числата е равен на дадено магическо число. Ако няма нито
            //една комбинация отговаряща на условието се отпечатва съобщение,
            //че не е намерено.



            //вход:
            //Първи ред – начало на интервала – цяло число в интервала[1...999]
            //Втори ред – край на интервала – цяло число в интервала[по - голямо от първото число...1000]
            //Трети ред – магическото число – цяло число в интервала[1...10000]

            int begining = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = begining; i <= end; i++)
            {
                for (int j = begining; j <= end; j++)
                {
                    counter++;

                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNum})");
                        return;
                    }
                }
            }
            //изход:
            //На конзолата трябва да се отпечата един ред, според резултата:
            //Ако е намерена комбинация чиито сбор на числата е равен на магическото число
            //"Combination N:{пореден номер} ({първото число} + {второ число} = {магическото число})"
            //Ако не е намерена комбинация отговаряща на условието
            //"{броят на всички комбинации} combinations - neither equals {магическото число}"

            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
        }
    }
}
