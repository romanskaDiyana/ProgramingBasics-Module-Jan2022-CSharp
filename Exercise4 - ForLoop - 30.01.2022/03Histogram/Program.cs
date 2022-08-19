using System;

namespace _03Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход:
            //Дадени са n цели числа в интервала [1…1000].

            int numberOfNumbers = int.Parse(Console.ReadLine());

            // групи на числа според това в кой интервал се намират;
            double p1Numbers = 0; //под 200
            double p2Numbers = 0; //200 до 399
            double p3Numbers = 0; //400 до 599
            double p4Numbers = 0; //600 до 799
            double p5Numbers = 0; //800 до 1000

            for (int i = 1; i <= numberOfNumbers; i++)
            {
                //Да се напише програма,
                //която изчислява и отпечатва процентите p1, p2, p3, p4 и p5.
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum <= 199)
                {
                    p1Numbers++;
                }
                else if (currentNum <= 399)
                {
                    p2Numbers++;
                }
                else if (currentNum <= 599)
                {
                    p3Numbers++;
                }
                else if (currentNum <= 799)
                {
                    p4Numbers++;
                }
                else 
                {
                    p5Numbers++;
                }
            }

            p1Numbers = p1Numbers / numberOfNumbers * 100; //взимаме броя числа в съответния диапазон
            p2Numbers = p2Numbers / numberOfNumbers * 100; //разделяме на броя числа и умножаваме * 100
            p3Numbers = p3Numbers / numberOfNumbers * 100; // за да намерим процента;
            p4Numbers = p4Numbers / numberOfNumbers * 100;
            p5Numbers = p5Numbers / numberOfNumbers * 100;

            //изход:
            //Да се отпечата на конзолата хистограмата – 5 реда, всеки от които съдържа число между 0% и 100%,
            //с точност две цифри след десетичната точка, например 25.00%, 66.67%, 57.14%.

            Console.WriteLine($"{p1Numbers:f2}%");
            Console.WriteLine($"{p2Numbers:f2}%");
            Console.WriteLine($"{p3Numbers:f2}%");
            Console.WriteLine($"{p4Numbers:f2}%");
            Console.WriteLine($"{p5Numbers:f2}%");

        }
    }
}
