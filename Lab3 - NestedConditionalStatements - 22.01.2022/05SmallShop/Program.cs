using System;

namespace _05SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем входни данни: име на продукт, град, количество

            string nameProduct = Console.ReadLine();
            string cityName = Console.ReadLine();
            double productQuantity = double.Parse(Console.ReadLine());

            //създаваме променлива с цената на продукта:
            double price = 0;


            //създаваме поредица от проверки за град 
            //за всяка проверка се създава отделна проверка за всеки продукт 
            switch (cityName)
            {
                case "Sofia":
                    if (nameProduct == "coffee")
                    {
                        price = 0.50;
                    }
                    else if (nameProduct == "water")
                    {
                        price = 0.80;
                    }
                    else if (nameProduct == "beer")
                    {
                        price = 1.20;
                    }
                    else if (nameProduct == "sweets")
                    {
                        price = 1.45;
                    }
                    else if (nameProduct == "peanuts")
                    {
                        price = 1.60;
                    }
                    break;
                case "Plovdiv":
                    if (nameProduct == "coffee")
                    {
                        price = 0.40;
                    }
                    else if (nameProduct == "water")
                    {
                        price = 0.70;
                    }
                    else if (nameProduct == "beer")
                    {
                        price = 1.15;
                    }
                    else if (nameProduct == "sweets")
                    {
                        price = 1.30;
                    }
                    else if (nameProduct == "peanuts")
                    {
                        price = 1.50;
                    }
                    break;
                case "Varna":
                    if (nameProduct == "coffee")
                    {
                        price = 0.45;
                    }
                    else if (nameProduct == "water")
                    {
                        price = 0.70;
                    }
                    else if (nameProduct == "beer")
                    {
                        price = 1.10;
                    }
                    else if (nameProduct == "sweets")
                    {
                        price = 1.35;
                    }
                    else if (nameProduct == "peanuts")
                    {
                        price = 1.55;
                    }
                    break;
            }

            // изчисляване на цената 
            double totalPrice = productQuantity * price;

            // печатаме 

            Console.WriteLine(totalPrice);



        }
    }
}
