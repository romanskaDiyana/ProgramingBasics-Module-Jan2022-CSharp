using System;

namespace _02FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            //условие:
            //Знае се, че цената на шортите е 75 % от цената на тениските,
            //а цената на чорапите е 20 % от цената на шортите.Бутонките струват
            //два пъти колкото тениската и шортите взети заедно. Тъй като
            //Пепи редовно пазарува от този магазин, той има карта за отстъпка на
            //стойност 15 % от общата сума на покупката. Ако сметката на
            //Пепи е по-висока или равна на дадена сума, той получава подарък –
            //точно копие на топката от световното. Напишете програма, която
            //изчислява дали Пепи е спечелил топката. 

            //Вход:
            //На първия ред - цената на тениската – реално число в интервала[1.00... 1000.00]
            //На втория ред - сумата, която трябва да достигне, за да спечели топка – реално число в интервала[100.00... 10 000.00]

            double tShirtPrice = double.Parse(Console.ReadLine());
            double priceLimit = double.Parse(Console.ReadLine());

            double shortPrice = tShirtPrice * 0.75;
            double socksPrice = shortPrice * 0.20;
            double shoesPrice = 2 * (shortPrice + tShirtPrice);

            double totalPrice = tShirtPrice + shortPrice + socksPrice + shoesPrice;
            double finalPrice = totalPrice - (totalPrice * 0.15);

            //Изход:
            //            На конзолата се отпечатват два реда:
            //    • Ако топката Е спечелена:
            //        ◦ "Yes, he will earn the world-cup replica ball!"
            //        ◦ "His sum is {сумата} lv."
            //    • Ако топката НЕ Е спечелена:
            //        ◦ "No, he will not earn the world-cup replica ball."
            //        ◦ "He needs {недостигащи пари} lv. more."
            //Резултатът да бъде форматиран до втората цифра след десетичната запетая.

            if (finalPrice >=priceLimit)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {finalPrice:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {priceLimit - finalPrice:f2} lv. more.");
            }



        }
    }
}
