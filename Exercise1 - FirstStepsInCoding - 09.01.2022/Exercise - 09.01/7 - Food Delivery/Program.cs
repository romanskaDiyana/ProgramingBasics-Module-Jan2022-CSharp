using System;

namespace _7___Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем:
            //брой пилешко меню;
            //брой меню с риба;
            //брой вегетарианско меню;

            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetableMenu = int.Parse(Console.ReadLine());

            //изчисляваме цената на менюта:
            double chickenPriceMenu = chickenMenu * 10.35;
            double fishPriceMenu = fishMenu * 12.40;
            double vegetablePriceMenu = vegetableMenu * 8.15;

            //изчисляваме обща сума:
            double PriceMenues = chickenPriceMenu + fishPriceMenu + vegetablePriceMenu;

            //изчисляваме сума на десерт:
            double desertPrice = PriceMenues * 0.2;

            //изчисляваме обща сума + доставка:

            double finalPrice = PriceMenues + desertPrice + 2.50;

            //печатаме обща сума:
            Console.WriteLine(finalPrice);


        }
    }
}
