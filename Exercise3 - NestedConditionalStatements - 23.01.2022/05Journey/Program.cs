using System;

namespace _05Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем от конзола бюджет и сезон:
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string typePlace = "";

            double price = 0;


            //бюджета се определя от дестинацията  - “Bulgaria", "Balkans” и ”Europe”
            //сезона определя, колко от бюджета ще се изхарчи:
            //        • При 100лв. или по-малко – някъде в България
            //Лято – 30 % от бюджета
            //Зима – 70 % от бюджета
            //        • При 1000лв. или по малко – някъде на Балканите
            //Лято – 40 % от бюджета
            //Зима – 80 % от бюджета
            //        • При повече от 1000лв. – някъде из Европа
            //При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.
            //сезона определя къде ще почива - „Camp” - лято  и „Hotel”, - зима ако е в Европа ще почива в хотел

            if (budget > 1000)
            {
                destination = "Europe";
                typePlace = "Hotel";
                price = budget * 0.9;
            }
            else if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    typePlace = "Camp";
                    price = budget * 0.3;
                }
                else if (season == "winter")
                {
                    typePlace = "Hotel";
                    price = budget * 0.7;
                }
            
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    typePlace = "Camp";
                    price = budget * 0.4;
                }
                else if (season == "winter")
                {
                    typePlace = "Hotel";
                    price = budget * 0.8;
                }
            }
            //а конзолата трябва да се отпечатат два реда.
            //• Първи ред – „Somewhere in [дестинация]“ измежду “Bulgaria", "Balkans” и ”Europe”
            //• Втори ред – “{ Вид почивка} – { Похарчена сума}“
            //    ◦ Почивката може да е между „Camp” и „Hotel”
            //    ◦ Сумата трябва да е закръглена с точност до вторият знак след запетаята.

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typePlace} - {price:f2}");

           
        }
    }
}
