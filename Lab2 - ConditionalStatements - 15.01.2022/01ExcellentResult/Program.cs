using System;

namespace _01ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем число, оценка:
            double grade = double.Parse(Console.ReadLine());

            //четем ако:
            if (grade >= 5.50)
            //печатаме:
            {
                Console.WriteLine("Excellent!");
            }
            else 
            { 
                Console.WriteLine("Try Again!"); 
            }

        }
    }
}
