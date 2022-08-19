using System;

namespace _01SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем времената:
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            //създаваме обща променлива за изчисляване на общото им време:

            int totalTime = firstTime + secondTime + thirdTime;

            //превръщаме минутите в секунди:

            int minutes = totalTime / 60; //защото в 1 минута има 60сек. 
            int seconds = totalTime % 60; //за да намерим остатъка. 
            //ако секундите са по-малко от 0 - трябва да се отпечата 0 отпред
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else 
            {
                Console.WriteLine($"{ minutes}:{ seconds}");
            }
        }
    }
}
