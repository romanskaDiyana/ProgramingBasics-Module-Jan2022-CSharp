using System;

namespace _01Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int day = 1; day <=28; day++)
            {
                for (int hour = 0; hour <= 23; hour++)
                {
                    for (int minutes = 0; minutes <= 59; minutes++)
                    {
                            Console.WriteLine($"{day:d2}.02.2022) - {hour:d2}:{minutes:d2}");
                        //d2 уверява се, че има две цифри. и прави 2 цифри. 
                    }
                }
            }
        }
    }
}
