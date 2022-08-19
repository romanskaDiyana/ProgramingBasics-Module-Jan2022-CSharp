using System;

namespace _03EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем цяло число 
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0 ) // когато се дели на 2 и не остава остатък е четно!
            {
                Console.WriteLine("even");
            }
            else 
            {
                Console.WriteLine("odd");
            }
            
        }
    }
}
