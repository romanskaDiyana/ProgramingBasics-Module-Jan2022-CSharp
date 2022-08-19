using System;

namespace _07Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем входните данни и ги запаметяваме в променливи:
            double peterBudget = double.Parse(Console.ReadLine());
            int videoCardNum = int.Parse(Console.ReadLine());
            int processorsNum = int.Parse(Console.ReadLine());
            int ramMemoryNum = int.Parse(Console.ReadLine());

            //изчисляваме каква е сумата за видеокарти: бр. видеокарти * 250;
            double videoCardPrice = videoCardNum * 250;

            //изчисляваме цената на процесорите за брой: сумата за видеокарти * 0.35; - 35%
            double processorsPrice = processorsNum * (videoCardPrice * 0.35);

            //изчисляваме сумата за рам памет: броя на рам памет * сумата;
            double ramMemoryPrice = ramMemoryNum * (videoCardPrice * 0.10);

            //общо сума, която да се заплати:
            double totalPrice = videoCardPrice + processorsPrice + ramMemoryPrice;
            //проверяваме броя на видеокарти > от процесори => 15% отстъпка
            if (videoCardNum > processorsNum)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }
            //да се намери разлика между обща сума и цената, която трябва да заплати:
            double difference = peterBudget - totalPrice;
            //проверяваме дали има достатъчно пари:

            if (difference >= 0)
            {
                Console.WriteLine($"You have {difference:f2} leva left!");
            }
            else 
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva more!");
            }
            
        }
    }
}
