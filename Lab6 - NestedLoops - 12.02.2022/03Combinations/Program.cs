using System;

namespace _03Combinations
{
    class Program
    {
        static void Main(string[] args)
        {


            //условие:
            //Напишете програма, която изчислява колко решения в естествените числа(включително и нулата) има уравнението:
            //x1 + x2 + x3 = n
            //Числото n е цяло число и се въвежда от конзолата. 

            int num = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int number3 = 0; number3 <= num; number3++)
            {
                for (int number2 = 0; number2 <= num; number2++)
                {
                    for (int number1 = 0; number1 <= num; number1++)
                    {
                        if (number1 + number2 + number3 == num)
                        {
                            counter++;                           
                          
                        }
                    }
                }
            }

            Console.WriteLine(counter);




        }
    }
}
