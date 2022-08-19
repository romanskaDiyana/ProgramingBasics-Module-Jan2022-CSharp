using System;

namespace _4___Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // четем брой страници в книга, страници за един час, броят на дните за 1 книга;
            
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysNeeded = int.Parse(Console.ReadLine());

            // изчисляваме общо време за четене на една книга;

            int sumTimeForABook = numberOfPages / pagesPerHour;

            //ичисляваме необходимите часове на ден; 
            int timeNeededPerDay = sumTimeForABook / daysNeeded;


            Console.WriteLine(timeNeededPerDay);
        }
    }
}
