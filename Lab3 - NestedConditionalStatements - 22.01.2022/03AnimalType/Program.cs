﻿using System;

namespace _03AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animalName = Console.ReadLine();

            switch (animalName)
            {

                case "dog":
                    Console.WriteLine("mammal");
                    break;

                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
