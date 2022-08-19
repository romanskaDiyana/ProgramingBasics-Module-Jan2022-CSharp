using System;

namespace _7___Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {architectName} will need {projectNumber * 3} hours to complete {projectNumber} project/s.");

        }
    }
}
