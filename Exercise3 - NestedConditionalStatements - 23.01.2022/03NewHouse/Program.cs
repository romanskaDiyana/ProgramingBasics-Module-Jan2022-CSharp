using System;

namespace _03NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем вход от конзолата:
            string flowersType = Console.ReadLine();
            int flowersNum = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            //проверка за всеки тип цвете:"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //във всяка проверка има вътрешна проверка

            if (flowersType == "Roses")
            {
                price = flowersNum * 5.0;
                if (flowersNum > 80)
                {
                    price = price - price * 0.1;
                }
               
            }
            else if (flowersType == "Dahlias")
            {
                price = flowersNum * 3.80;
                if (flowersNum > 90)
                {
                    price = price - price * 0.15;
                }
                

            }
            else if (flowersType == "Tulips")
            {
                price = flowersNum * 2.80;
                if (flowersNum > 80)
                {
                    price = price - price * 0.15;
                }
                
            }
            else if (flowersType == "Narcissus")
            {
                price = flowersNum * 3.0;
                if (flowersNum < 120)
                {
                    price = price + price * 0.15;
                }
                
            }
            else if (flowersType == "Gladiolus")
            {
                price = flowersNum * 2.50;
                if (flowersNum < 80) // = 150бр. 
                {
                    price = price + price * 0.20; // 
                }
                
            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersNum} {flowersType} and {(budget - price):f2} leva left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money, you need {(price - budget):f2} leva more.");
            }
            
        }
    }
}
