using System;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-ва задача:
            //четем от конзолата USD

            double usd = double.Parse(Console.ReadLine());

            //преобразуване bgn = usd * 1.79549
            double bgn = usd * 1.79549;

            //изписване на конзолата bgn

            Console.WriteLine(bgn);
        }
    }
}
