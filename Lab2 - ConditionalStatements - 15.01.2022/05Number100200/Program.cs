using System;

namespace _05Number100200
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем цяло число;
            int number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            if (number >= 100 && number <= 200) // оператор за диапазон и сравнение!!!!!
            {
                Console.WriteLine("Between 100 and 200");
            }
            if (number > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
