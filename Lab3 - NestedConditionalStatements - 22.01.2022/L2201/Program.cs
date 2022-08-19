using System;

namespace L2201
{
    class Program
    {
        static void Main(string[] args)
        {
            //Деление на 10 и 100 
            //125 % 10 = 5 => 125 = 10 * 12 + 5;
            //125 % 100 = 25 => 125 = 100 + 25;

            string weather = Console.ReadLine();


            switch (weather)
            {
                case "sunny":
                    Console.WriteLine();
                    break;
                case "cloudy":
                    Console.WriteLine();
                    break;
                case "ice":
                    Console.WriteLine();
                    break;
                case "snowy":
                    Console.WriteLine();
                    break;
                default:
                    break;
            }

            switch (weather)
            {
                case "sunny":
                    Console.WriteLine("Go for a walk!");//тук се пише кода 
                    Console.WriteLine("The weather is nice!");
                    break;
            }
            
            switch (weather)
            {
                case "icy":
                    Console.WriteLine("Go for a walk!");//тук се пише кода 
                    Console.WriteLine("The weather is nice!");
                    break;
            }
            switch (weather)
            {
                case "snowy":
                    Console.WriteLine("Go for a walk!");//тук се пише кода 
                    Console.WriteLine("The weather is nice!");
                    break;

                default:
                    Console.WriteLine("Invalid Weather");
                    break;


            }
            int age = 19;

            switch (age)
            {
                case  // работи само за 2022 версия без judge
                        Console.WriteLine("Go have a beer");

                case <= 20:
                    Console.WriteLine("Hello");
                    break;
                default:
                    break;

                    //Логически оператори

                    int num = int.Parse(Console.ReadLine());


                    string dayWeek = Console.ReadLine();

                    if (dayWeek == "Monday" || dayWeek == "Tuesday" || dayWeek == "Friday")
                    {
                        Console.WriteLine(12);
                    }
                    else if (dayWeek == "Wednesday" || dayWeek == "Thursday")
                    {
                        Console.WriteLine(14);
                    }
                    else 
                    {
                        Console.WriteLine(16);
                    }


                    

            }
        }
    }
}
