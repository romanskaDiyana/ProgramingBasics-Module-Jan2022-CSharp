﻿using System;

namespace _08CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string weekDay = Console.ReadLine();

            switch (weekDay)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    Console.WriteLine("12");
                    break;

                case "Wednesday":
                case "Thursday":
                    Console.WriteLine("14");
                    break;

                case "Saturday":
                case "Sunday":
                    Console.WriteLine("16");
                    break;
            }
        }
    }
}
