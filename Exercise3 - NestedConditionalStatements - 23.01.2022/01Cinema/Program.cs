using System;

namespace _01Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем от конзолата: 
            string typeTicket = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int coloumn = int.Parse(Console.ReadLine());
            
            //изчисляваме броя на местата в залата:
            double totalPlaces = row * coloumn; //кръщаваме я Income - за да се позлва примерния изход;
            double income = 0.0;
            //проверяваме типа на билетите и изчисляваме приходите от билетите:
            if (typeTicket == "Premiere")
            {
                income = totalPlaces * 12;
            }
            else if (typeTicket == "Normal")
            {
                income = totalPlaces * 7.5;
            }
            else if (typeTicket == "Discount")
            {
                income = totalPlaces * 5;
            }
            //извеждане на резултат: 

            Console.WriteLine($"{income:f2} leva");
            // или Console.WriteLine($"{0:f2} leva", income);
            // 0 - позиция на промелива след запетайка.
            
        }
    }
}
