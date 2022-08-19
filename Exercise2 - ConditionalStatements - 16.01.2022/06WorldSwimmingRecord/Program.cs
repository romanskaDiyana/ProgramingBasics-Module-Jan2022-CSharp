using System;

namespace _06WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем 
            double recordSec = double.Parse(Console.ReadLine());
            double distanceMetters = double.Parse(Console.ReadLine());
            double timeSecForAMetter = double.Parse(Console.ReadLine());

            double secSum = distanceMetters * timeSecForAMetter;
            double numSlow= Math.Floor (distanceMetters / 15);
            double secSlow = numSlow * 12.5;
            double totalSec = secSum + secSlow;

            if (totalSec < recordSec) 
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {Math.Abs(totalSec):f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(totalSec - recordSec):f2} seconds slower.");
            }

        }
    }
}
