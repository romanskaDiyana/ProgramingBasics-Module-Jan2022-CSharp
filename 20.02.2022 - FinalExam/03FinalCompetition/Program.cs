using System;

namespace _03FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход:
            //            От конзолата се четат 4 реда:
            //1.Брой танцьори – цяло число в интервала[1 … 10]
            //2.Брой точки – реално число в интервала[1.00 … 10000.00]
            //3.Сезон –  текст със следните възможности -"summer" или "winter"
            //4.Място – текст със следните възможности -"Bulgaria" или "Abroad"

            int numDancers = int.Parse(Console.ReadLine());
            double numPoints = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double price = 0;
            double price2 = numPoints * numDancers;
            double totalPrice = 0;
            double priceForEach = 0;

            //    • Ако състезанието се е провело в България паричната награда
            //    се изчислява като се умножат точките по броя участниците.
            //    • Ако се е провело в чужбина – се умножават
            //    броя участници по броя точки и към тях се добавя 50 % от получената сума. 
            //От получената сума се изваждат разходите посочени в
            //проценти спрямо сезона, през който се е провел:

            if (season == "summer")
            {
                if (place == "Bulgaria")
                {
                    price = price2 - (price2 * 0.05);
                }
                else if (place == "Abroad")
                {
                    price = (price2 + (price2 * 0.50)) - ((price2 + (price2 * 0.50)) * 0.10);
                }
                
            }
            else if (season == "winter")
            {
                if (place == "Bulgaria")
                {
                    price = price2 - (price2 * 0.08);
                }
                else if (place =="Abroad")
                {
                    price = (price2 + (price2 * 0.50)) - ((price2 + (price2 * 0.50)) * 0.15);
                }

            }

            //След завръщането си групата дарява 75 % от сумата, след
            //приспаднатите разходи, за благотворителност.
            //Останалата сума се разпределя между членовете на групата.
            //Да се  напише програма, която, изчислява колко
            //пари са дадени за благотворителност и колко е получил всеки
            //един член на групата.


            totalPrice = price - (price * 0.75);

            priceForEach = totalPrice / numDancers;

            //Изход:
            //            На конзолата се отпечатват 2 реда:
            //    • Сумата, която са дали за благотворителност
            //"Charity - {сума за благотворителност}"
            //    • Сумата, която е получил всеки танцьор
            //"Money per dancer - {сума за танцьор}"
            //Сумите да бъдат форматирани до втория знак след десетичната запетая.

            Console.WriteLine($"Charity - {(price * 0.75):f2}");
            Console.WriteLine($"Money per dancer - {priceForEach:f2}");
        }
    }
}
