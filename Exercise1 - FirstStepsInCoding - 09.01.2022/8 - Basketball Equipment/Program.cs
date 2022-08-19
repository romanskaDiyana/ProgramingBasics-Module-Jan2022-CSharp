using System;

namespace _8___Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            // четем такса за 1 година;
            double taxPerYear = double.Parse(Console.ReadLine());

            // цена на кецове, екип, топка и аксесоари;
            //  кецове – цената им е 40 % по - малка от таксата за една година
            //  екип – цената му е 20 % по - евтина от тази на кецовете
            //  топка – цената ѝ е 1 / 4 от цената на баскетболния екип
            //  аксесоари – цената им е 1 / 5 от цената на баскетболната топка

            double shoesPrice = taxPerYear - taxPerYear * (40 / 100.0);
            double outFitPrice = shoesPrice - shoesPrice * (20 / 100.0);
            double ballPrice = outFitPrice / 4;
            double accPrice = ballPrice / 5;

            // обща сума; такса + кецове, екип, топка и аксесоари; 

            double sum = taxPerYear + shoesPrice + outFitPrice + ballPrice + accPrice;

            // печатаме сумата на конзолата;

            Console.WriteLine(sum);
        }
    }
}
