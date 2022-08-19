using System;

namespace _06VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
               char currentsymbol = text[i];
               switch (currentsymbol)
               {
                    case 'a':
                        sum++;
                break;
                    case 'e':
                        sum += 2;
                break;
                    case 'i':
                        sum += 3;
                break;
                    case 'o':
                        sum += 4;
                break;
                    case 'u':
                        sum += 5;
                break;
               }
            }

            Console.WriteLine(sum);
        }
    }
}
