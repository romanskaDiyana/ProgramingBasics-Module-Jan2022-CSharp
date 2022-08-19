using System;

namespace _05Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double changeToReturn = 100 * double.Parse(Console.ReadLine());

            

            int counter = 0;

            // 2 , 1, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01; - монети;

            //5.23 => 2х2 + 1х1 , 1х0.20, 1х0.02 + 1х0.01;

            // 5.23 - 2 = 3,23 (counter = 1)
            // 3,23 - 2 = 1,23 (counter = 1+ 1 = 2)
            // 1,23 - 1 = 0,23 (counter = 2+1 = 3)
            // 0.23 - 0.20 = 0.03 (counter = 2+1 = 4)

            while (changeToReturn > 0)
            {
                if (changeToReturn >= 200)
                {
                    changeToReturn -= 200;
                    counter++;
                }
                else if (changeToReturn >= 100)
                {
                    changeToReturn -= 100;
                    counter++;
                }
                else if (changeToReturn >= 50)
                {
                    changeToReturn -= 50;
                    counter++;
                }
                else if (changeToReturn >= 20)
                {
                    changeToReturn -= 20;
                    counter++;
                }
                else if (changeToReturn >= 10)
                {
                    changeToReturn -= 10;
                    counter++;
                }
                else if (changeToReturn >= 5)
                {
                    changeToReturn -= 5;
                    counter++;
                }
                else if (changeToReturn >= 2)
                {
                    changeToReturn -= 2;
                    counter++;
                }
                else if (changeToReturn >= 1)
                {
                    changeToReturn -= 1;
                    counter++;
                }
                else
                {
                    changeToReturn = 0;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
