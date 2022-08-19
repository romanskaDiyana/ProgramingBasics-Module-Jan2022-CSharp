using System;

namespace _12TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double percentCom = 0;


            switch (city)
            {
                case "Sofia":
                    if (sales > 0 && sales <=500)
                    {
                        percentCom = 0.05;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        percentCom = 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        percentCom = 0.08;
                    }
                    else  
                    {
                        percentCom = 0.12;
                    }
                    break;

                case "Varna":
                    if (sales > 0 && sales <= 500)
                    {
                        percentCom = 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        percentCom = 0.075;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        percentCom = 0.10;
                    }
                    else
                    {
                        percentCom = 0.13;
                    }
                    break;

                case "Plovdiv":
                    if (sales > 0 && sales <= 500)
                    {
                        percentCom = 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        percentCom = 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        percentCom = 0.12;
                    }
                    else
                    {
                        percentCom = 0.145;
                    }
                    break;

            }

            double comission = percentCom * sales;

            if (comission > 0)
            {
                Console.WriteLine($"{comission:f2}");
            }
            else 
            {
                Console.WriteLine("error");
            }
        }
    }
}
