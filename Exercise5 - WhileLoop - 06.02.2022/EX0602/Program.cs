using System;

namespace EX0602
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            for (int i = 1; i <= 10; i++)
            {
                input = Console.ReadLine();

                if (input == "No")
                {
                    continue;
                }

                int num = int.Parse(input);


                Console.WriteLine(num * 2);

            }


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            int j = 1;

            while (j<=10)
            {
                Console.WriteLine(j);

                j++;
            }



            
        }
    }
}
