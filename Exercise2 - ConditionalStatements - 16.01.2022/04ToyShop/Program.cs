using System;

namespace _04ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем:
            //входни данни и ги запаметяваме в промеливи 
            double priceVacation = double.Parse(Console.ReadLine());
            double puzzleNum = int.Parse(Console.ReadLine());
            double dollNum = int.Parse(Console.ReadLine());
            double bearNum = int.Parse(Console.ReadLine());
            double minionNum = int.Parse(Console.ReadLine());
            double truckMNum = int.Parse(Console.ReadLine());

            // намираме общ брой играчки:
            double totalToysNum = puzzleNum 
                + dollNum 
                + bearNum 
                + minionNum 
                + truckMNum;
            //намираме общата сума на играчките:
            double totalToysPrice = (puzzleNum * 2.6) 
                + (dollNum * 3) 
                + (bearNum * 4.1) 
                + (minionNum * 8.2) 
                + (truckMNum * 2);

            //проверяваме дали броя на закупените играчки е >= 50:
            //ако са < 50 - нищо, ако са >= 50 - 25% отстъпка; 
            if (totalToysNum >= 50)
            {
                totalToysPrice = totalToysPrice - (totalToysPrice * 0.25); 
            }

            //трябва да извадим 10% от крайната сума за наем:
            totalToysPrice = totalToysPrice - (totalToysPrice * 0.10);

            //проверяваме дали печалбата е достатъчна за екскурзия:
            // => ако печалбата е >= на цената на екскурзията => отпечатваме "да" и остатъка; - общата сума - цената на екскурзията;
            // => ако поечалбата е < от цената на екскурзията отпечатваме "не" и остатъка; (цена на екскурзия - обща сума )

            double difference = totalToysPrice - priceVacation;

            if (difference>=0)
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money! {Math.Abs(difference):f2} lv needed.");
            }
        }
    }
}
