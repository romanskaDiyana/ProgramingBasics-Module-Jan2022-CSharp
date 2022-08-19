using System;

namespace _05CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int start = 0; start < text.Length; start++)
            {
                //s o f t u n i
                //0 1 2 3 4 5 6

                char letter = text[start];
                Console.WriteLine(letter);

            }

            string text1 = Console.ReadLine();

            int counterStart = 0;

            for (; counterStart < text1.Length;)
            {
                char letter = text[counterStart];
                Console.WriteLine(letter);
            }

            counterStart++;


        }
    }
}
