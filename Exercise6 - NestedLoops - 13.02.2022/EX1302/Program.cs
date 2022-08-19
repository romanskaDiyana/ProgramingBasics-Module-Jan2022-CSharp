using System;

namespace EX1302
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // _ _ _ _ _ 12345

            string currentNum = n.ToString();

            //currentNUm има дължина (currentNum.Lenght - 5)
            //позиция 0: "1"=> currentNum[0]
            //позиция 1: "2"=> currentNum[1]
            //позиция 2: "3"=> currentNum[2]
            //позиция 3: "4"=> currentNum[3]
            //позиция 4: "5"=> currentNum[4]

            int sum = 0;

            Console.WriteLine($"Stringa {currentNum} ima dyljina = {currentNum.Length}");

            for (int i = 0; i <= currentNum.Length; i++)
            {
                Console.WriteLine($"Poziciqta e: {i}: '{currentNum[i]}' ");

                sum += currentNum[i];              
                Console.WriteLine($"Sumata do momenta e: {sum}");
                Console.WriteLine("------------------------------------");
            }
        }
    }
}
