using System;

namespace _05AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход:
            //Напишете програма, която пресмята колко общо пари има в сметката,
            //след като направите определен брой вноски.
            //На всеки ред ще получавате сумата, която трябва да внесете в сметката,
            //до получаване на команда "NoMoreMoney" .
            //При всяка получена сума на конзолата трябва да се извежда "Increase: "
            //+ сумата и тя да се прибавя в сметката.
            //Ако получите число по-малко от 0 на конзолата трябва да се изведе
            //"Invalid operation!" и програмата да приключи.
            //Когато програмата приключи трябва да се принтира
            //"Total: " + общата сума в сметката форматирана до
            //втория знак след десетичната запетая. 

            string enter = Console.ReadLine(); //вноски 

            double balance = 0; // сметка 

            while (enter != "NoMoreMoney") //докато няма пари
            {
                double amount = double.Parse(enter); //превръщаме от string в double и ни връща число;

                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                balance += amount; //към сметката добавяме върнатия string

                Console.WriteLine($"Increase: {amount:f2}");

                enter = Console.ReadLine();
            
            }

            Console.WriteLine($"Total: {balance:f2}");




        }
    }
}
