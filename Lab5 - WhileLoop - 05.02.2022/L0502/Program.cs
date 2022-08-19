using System;

namespace L0502
{
    class Program
    {
        static void Main(string[] args)
        {


            // string areThereAnyDishes = Console.ReadLine();

            // yes/no

            // while (areThereAnyDishes == "yes")
            //{
            //   Console.WriteLine("Washing a dish......");
            //  areThereAnyDishes = Console.ReadLine();
            // }
            //string input = Console.ReadLine();
            //while (input != "Stop")
            //{
            //    Console.WriteLine("Invalid input");
            //    input = Console.ReadLine();

            //}

            string enter = Console.ReadLine(); //вноски 

            double balance = 0; // сметка 

            while (enter != "NoMoreMOney") //докато няма пари
            {
                double amount = double.Parse(enter); //превръщаме от string в double и ни връща число;

                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    enter = Console.ReadLine();
                    continue; // прескача долните редове!
                }
                    balance += amount; //към сметката добавяме върнатия string

                    Console.WriteLine($"Increase:{amount:2}");

                    enter = Console.ReadLine();
                

                Console.WriteLine($"Total: {balance:f2}");
            }

        }
    }
}
