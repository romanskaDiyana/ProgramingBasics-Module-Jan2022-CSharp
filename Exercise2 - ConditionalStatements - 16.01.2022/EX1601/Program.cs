using System;

namespace EX1601
{
    class Program
    {
        static void Main(string[] args)

        {

            //начини за проверка на едно число дали е нечетно!!!

            // (num % 2 == 0), 
            int num = 5;

            if (num % 2 == 0)
            {
                Console.WriteLine("chetno");
            }
            else 
            {
                Console.WriteLine("nechetno");
            }
            Console.WriteLine("------------------");

            if (!(num % 2 == 0))
            {
                Console.WriteLine("nechetno");
            }
            else
            {
                Console.WriteLine("chetno");
            }
            Console.WriteLine("------------------");
            if (num % 2 != 0)
            {
                Console.WriteLine("nechetno");
            }
            else
            {
                Console.WriteLine("chetno");
            }
            Console.WriteLine("------------------");

            if (num % 2 == 1)
            {
                Console.WriteLine("nechetno");
            }
            else
            {
                Console.WriteLine("chetno");
            }
            Console.WriteLine("------------------");
        }    
    }
}
