using System;

namespace _05Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем данни и ги запаметяваме в променливи:
            double filmBudget = double.Parse(Console.ReadLine());
            int actorsNum = int.Parse(Console.ReadLine());
            double actorsClothing = double.Parse(Console.ReadLine());

            //изчисляваме стойността на декора - 10% от бюджета 
            double decorPrice = filmBudget * 0.10;
            double actorsClothingPrice = actorsClothing * actorsNum;
            //изчисляваме ако броя на статистите надвишава 150бр. => 10% отстъпка:
            if (actorsNum >= 150)
            {
                actorsClothingPrice = actorsClothingPrice - (actorsClothingPrice * 0.10); //за да изчислим - отстъпката;
            }
            double totalSum = decorPrice + actorsClothingPrice;

            if (totalSum > filmBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(totalSum - filmBudget):f2} leva more.");
            }
            if (totalSum <= filmBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs(filmBudget- totalSum):f2} leva left.");
            }
        }
    }
}
