using System;

namespace _5___Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            // четем от конзолата numbersPen;
            // четем от конзолата numbersMarkers;
            // четем от конзолата detergentlitters;
            // четем от конзолата percentdiscount
            // 4-те променливи от тип int;
            // 3 променливи - количество, 1 % намаление;

            int numbersPens = int.Parse(Console.ReadLine());
            int numbersMarkers = int.Parse(Console.ReadLine());
            int detergentLitters = int.Parse(Console.ReadLine());

            int percentDiscount = int.Parse(Console.ReadLine());

            // всеки от тях колко ще струва; 
            // химикали - 5,80лв, пакет маркери - 7,80лв. препарат 1,20 за литър;

            double pensPrice = numbersPens * 5.80;
            double markersPrice = numbersMarkers * 7.20;
            double detergentPrice = detergentLitters * 1.20;

            // обща сума; 
            double priceSupplies = pensPrice + markersPrice + detergentPrice;

            // процент от обща сума отстъпка; 
            double finalPrice = priceSupplies - priceSupplies * (percentDiscount / 100.0);

            // печатаме колко пари ще са нужни на Ани;
            Console.WriteLine(finalPrice);

        }
    }
}
