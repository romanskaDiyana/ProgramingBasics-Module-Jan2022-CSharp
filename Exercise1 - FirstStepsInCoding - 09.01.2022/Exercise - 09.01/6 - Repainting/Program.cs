using System;

namespace _6___Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем:
            //количество найлон ;
            //необходимо количество;
            //количество разредител;
            //часове;

            double plastic = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double diluent = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            //изчисляваме цена на консумативи:
            double plasticPrice = (plastic +2) * 1.50;
            double paintPrice = (paint + (0.1 * paint)) * 14.50;
            double diluentPrice = diluent * 5;

            //изчисляваме обща цена на консумативи + торбичка:
            double suppliesPrice = plasticPrice + paintPrice + diluentPrice + 0.40;

            //изчисляваме сума за майстори:
            double workmenPrice = (suppliesPrice * 0.3) * hours;

            //изчисляваме крайна сума:
            double finalPrice = suppliesPrice + workmenPrice;

            //печатаме крайна сума:
            Console.WriteLine(finalPrice);









        }
    }
}
