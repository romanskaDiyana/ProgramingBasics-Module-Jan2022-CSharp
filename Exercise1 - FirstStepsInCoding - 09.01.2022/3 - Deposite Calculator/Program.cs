using System;

namespace _3___Deposite_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем депозираната сума, срок на депозита, годишен лихвен процент; 

            double depositSum = double.Parse(Console.ReadLine());
            int depositPeriod = int.Parse(Console.ReadLine());

            double percentYearIncrease = double.Parse(Console.ReadLine());

            //изчисляваме натрупаната годишна лихва 

            double yearIncrease = depositSum * percentYearIncrease * 0.01;

            // изчисляваме лихвата за 1 месец

            double monthIncrease = yearIncrease / 12;

            //изчисляваме общата крайна сума

            double finalSum = depositSum + depositPeriod * monthIncrease;

            //печатаме резултата

            Console.WriteLine(finalSum);
        }
    }
}
