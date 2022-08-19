using System;

namespace _09SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем входни данни
            int numberDays = int.Parse(Console.ReadLine());
            string typePlace = Console.ReadLine();
            string rating = Console.ReadLine();
            //(пример: 11 дни = 10 нощувки) и видът на помещението
            numberDays = numberDays - 1;
            //Налични са следните видове помещения, със следните цени за престой:
            //▪ "room for one person" – 18.00 лв за нощувка
            //▪ "apartment" – 25.00 лв за нощувка
            //▪ "president apartment" – 35.00 лв за нощувка
            double totalPrice = 0;
            double roomForOnePrice = 0;
            double apartmentPrice = 0;
            double presidentApartmentPrice = 0;
            //Според броят на дните, в които ще остане в хотела
            //(пример: 11 дни = 10 нощувки) и видът на помещението
            if (numberDays <= 10)
            {
                if (typePlace == "room for one person")
                {
                    totalPrice = numberDays * 18;
                }
                else if (typePlace == "apartment")
                {
                    totalPrice = (numberDays * 25) - ((numberDays * 25) * 0.30);
                }
                else if (typePlace == "president apartment")
                {
                    totalPrice = (numberDays * 35) - ((numberDays * 35) * 0.10);
                }
            }
            else if (numberDays >= 15)
            { 
                if (typePlace == "room for one person")
                {
                    totalPrice = numberDays * 18;
                }
                else if (typePlace == "apartment")
                {
                    totalPrice = (numberDays * 25) - ((numberDays * 25) * 0.50);
                }
                else if (typePlace == "president apartment")
                {
                    totalPrice = (numberDays * 35) - ((numberDays * 35) * 0.20);
                }
            }
            else if (numberDays > 10 && numberDays <= 15)
            {
                if (typePlace == "room for one person")
                {
                    totalPrice = numberDays * 18;
                }
                else if (typePlace == "apartment")
                {
                    totalPrice = (numberDays * 25) - ((numberDays * 25) * 0.35);
                }
                else if (typePlace == "president apartment")
                {
                    totalPrice = (numberDays * 35) - ((numberDays * 35) * 0.15);
                }
            }
            // След престоя, оценката на Атанас за услугите на хотела може да е позитивна
            //(positive) или негативна (negative) . Ако оценката му е позитивна, към цената с вече приспаднатото намаление Атанас добавя 25% от нея.
            //Ако оценката му е негативна приспада от цената 10%.

            if (rating == "positive")
            {
                totalPrice = totalPrice + totalPrice * 0.25;
            }
            else if (rating == "negative")
            {
                totalPrice = totalPrice - totalPrice * 0.10;
            }
            //На конзолата трябва да се отпечата един ред:
            //Цената за престоят му в хотела, форматирана до втория знак след
            //десетичната запетая.
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
