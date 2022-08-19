using System;

namespace _01Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());

            int nightNum = int.Parse(Console.ReadLine());
            double cardsNum = int.Parse(Console.ReadLine());
            int ticketNum = int.Parse(Console.ReadLine());

            double nightPrice = 20;
            double cardPrice = 1.60;
            double ticketPrice = 6;

            double nightTotal = nightPrice * nightNum;
            double cardTotal = cardPrice * cardsNum;
            double ticketTotal = ticketNum * ticketPrice;

            double totalPrice = numberPeople * (nightTotal + ticketTotal + cardTotal);

            double finalPrice = (totalPrice * 0.25) + totalPrice;

            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
