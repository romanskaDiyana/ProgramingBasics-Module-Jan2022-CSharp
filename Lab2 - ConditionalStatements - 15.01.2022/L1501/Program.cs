using System;

namespace L1501
{
    class Program
    {
        static void Main(string[] args)
        {

            //Conditional Statments

            //Логически израз - Булев израз

            Console.WriteLine(5 <= 6); // True - важи за цели числа и дробни; 
            Console.WriteLine(5 == 6); //False

            Console.WriteLine("softuni" == "Softuni");  //False - casesensitive; важи само за равенство или различие  != ==!


            int age = int.Parse(Console.ReadLine()); //дали е пълнолетен;

            bool isOfAge = age >= 18;
            Console.WriteLine(isOfAge);

            //Прости проверки

            //example 1 с bool
            int a = 5;
            bool isPositive = a > 0; //true

            if (isPositive)
            { Console.WriteLine("The number is positive"); } //ако isPositive е true, влез и изпълни този код;

            //example 2 без bool
            int age1 = 39;
            if (age1 >= 18) ;
            { Console.WriteLine("You can drink beer!"); }

            //if/else


            //закръгляне и форматиране:

            double up = Math.Ceiling(23.45); //закръгля до по-голямото кръгло число; - 24
            double down = Math.Floor(45.67); // закръгля до по-малкото кръгло число; - 46

            double round = Math.Round(45.657812, 2); // закръгляне до знак - 2 - 45,66

            double num = 1.454548;
            Console.WriteLine($"{num:f2}"); //форматира и закръгля;
            Console.WriteLine($"{Math.Round(num, 4)}"); //не изписва 0!!!!

            //разлика: не изписва 0!!!

            //ДЕБЪГВАНЕ!!!!!!

            //Задача 2!!!! - "разнищване на задачата"


            //Серия от проверки

            string weather = Console.ReadLine();
            //sunny,cloudy,rainy

            if (weather == "sunny")
            {
                Console.WriteLine("Go for a walk!");
            }
            else if (weather == "cloudy") //серия от проверки - пропускане, ако намери това което е вярно; 
            {
                Console.WriteLine("Take un umbrella!");
            }
            else if (weather == "rainy")
            {
                Console.WriteLine("Stay at home!");
            }

            //Живот на променлива - различно за различни начини

            //обхват в който може да бъде използвана;

            double salary =  0; //declaration -> initialization 
            string currentDay = "Monday";

            if (currentDay == "Monday")
            {
                salary = double.Parse(Console.ReadLine()); //когато променливата е само в if - тя не важи извън него
            } 
            Console.WriteLine(salary); //няма присвоена стойност


        }
    }
}
