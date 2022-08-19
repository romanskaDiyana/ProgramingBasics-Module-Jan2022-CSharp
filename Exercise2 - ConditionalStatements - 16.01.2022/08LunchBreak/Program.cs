using System;

namespace _08LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            // четем 
            // време за обедна почивка 8/8
            // 1/8 = за обяд 
            // 1/4 = за отдих - 2/8
            // 1/8 обяд + 1/4 (2/8 = 3/8 - сме заети 
            // колко време може да отделим за сериала
            // 8/8 - 3/8 = 5/8 за сериал от обедна почивка

            string seriesName = Console.ReadLine();
            double seriesTime = int.Parse(Console.ReadLine());
            double lunchBreakTime = int.Parse(Console.ReadLine());

            double timeForSeries = lunchBreakTime * 5 / 8;
            //ако сериала  = 60, време 80, изваждаме от времето за сериала продължителността на сериала 
            if (timeForSeries >= seriesTime)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeForSeries - seriesTime)} minutes free time.");
            }
            else 
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(seriesTime - timeForSeries)} more minutes.");
            }

        }
    }
}
