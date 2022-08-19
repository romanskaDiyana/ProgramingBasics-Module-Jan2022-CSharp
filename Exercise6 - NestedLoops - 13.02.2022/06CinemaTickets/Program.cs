using System;

namespace _06CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine()); //последното число което трябва да се отпечата на конзолата
            int currentNum = 1; //текущо число

            for (int row = 1; row <= num; row++) 
            {
                for (int structure = 1; structure <= row; structure++) //вътрешен цикъл, структурира пирамидата
                {
                    Console.Write(currentNum+" "); //space - за да се отделят 
                    currentNum++; 

                    if (currentNum > num)
                    {
                        return;
                    }
                }
                Console.WriteLine(); // за да се отдели реда
            }           
        }
    }
}
