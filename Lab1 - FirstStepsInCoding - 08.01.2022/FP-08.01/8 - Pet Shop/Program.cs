using System;

namespace _8___Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberPacksDog = double.Parse(Console.ReadLine());
            double numberPacksCat = double.Parse(Console.ReadLine());

            double priceDogFood = numberPacksDog * 2.5;
            double priceCatFood = numberPacksCat * 4;
            double finalPrice = priceDogFood + priceCatFood;


            Console.WriteLine($"{finalPrice} lv. ");

        }
    }
}
