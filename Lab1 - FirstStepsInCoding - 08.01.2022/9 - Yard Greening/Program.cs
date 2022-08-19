using System;

namespace _9___Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeter = double.Parse(Console.ReadLine());

            double firstPrice = squareMeter * 7.61;
            double discountPrice = firstPrice * 0.18;
            double finalPrice = firstPrice - discountPrice;

            Console.WriteLine(finalPrice + " lv.");
            Console.WriteLine(discountPrice + " lv.");
        }
    }
}
