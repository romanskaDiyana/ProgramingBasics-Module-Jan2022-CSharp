using System;

namespace _02SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем входни данни:
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            //създаваме промеливи за облекло и обувки: 


            string outfit = "";
            string shoes = "";

            // 3 проверки - в кое време от денонощието сме - Morning, Afternoon, Evening;
            // във всяка трябва да има по 3 вътрешни
            // 10<= и <=18, м/у <18 и <=24, >=25;
            switch (timeOfDay)
            {
                case "Morning":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees >= 25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;

                case "Afternoon":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (degrees >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    break;
            }
           
            //отпечатваме резултат:

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");

        }
    }
}
