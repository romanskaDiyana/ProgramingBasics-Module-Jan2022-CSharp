using System;

namespace _3___Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем депозирана сума, срок на депозита (в месеци), годишем лихвен процент;

            int depositSum = int.Parse(Console.ReadLine());
            int depositPeriod = int.Parse(Console.ReadLine());

            double percentYearIncrease = double.Parse(Console.ReadLine());

            //изчисляваме натрупаната лихва за 1 година;

            double yearIncrease = depositSum - depositSum *(percentYearIncrease / 100.0);


            //изчисляваме лихвата за 1 месец;

            double monthIncrease = yearIncrease / 12;


            //изчисляваме за посочения период обща сума;

            double finalSum = depositSum + (depositPeriod * monthIncrease);


            //печатаме обща сума;

            Console.WriteLine(finalSum);
        }
    }
}
