using System;

namespace L1202
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 начина да прекъснем вложен цикъл

            //1-ви начин: bool flag

            bool flag = false;

            for (int day = 1; day <= 28; day++) //flag - използва се за комуникация между 2 цикъла;
            {
                for (int hour = 0; hour <= 23; hour++)
                {
                    for (int minutes = 0; minutes <= 59; minutes++)
                    {
                        Console.WriteLine($"{day:d2}.02.2022) - {hour:d2}:{minutes:d2}");
                        if (hour == 22 && minutes == 30)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        break;
                    }
                }
                if (flag == true)
                {
                   break;
                }
            }

            //2-ри начин: RETURN
            for (int day = 1; day <= 28; day++) //flag - използва се за комуникация между 2 цикъла;
            {
                for (int hour = 0; hour <= 23; hour++)
                {
                    for (int minutes = 0; minutes <= 59; minutes++)
                    {
                        Console.WriteLine($"{day:d2}.02.2022) - {hour:d2}:{minutes:d2}");
                        if (hour == 22 && minutes == 30)
                        {                           
                            return; //РАБОТИ ЗА MAIN METODE
                        }
                    }
                }
            }

            //3-ти начин: Environment.Exit(0);
            for (int day = 1; day <= 28; day++) //flag - използва се за комуникация между 2 цикъла;
            {
                for (int hour = 0; hour <= 23; hour++)
                {
                    for (int minutes = 0; minutes <= 59; minutes++)
                    {
                        Console.WriteLine($"{day:d2}.02.2022) - {hour:d2}:{minutes:d2}");
                        if (hour == 22 && minutes == 30)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
    }
}
