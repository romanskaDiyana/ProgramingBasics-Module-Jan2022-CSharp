using System;

namespace _01ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход:
            //Напишете програма, която чете текст от конзолата
            //(стринг) и го принтира, докато не получи командата "Stop".

            string text = Console.ReadLine();

            while (text != "Stop")
            {
                Console.WriteLine(text);
                text = Console.ReadLine();
            }

        }
    }
}
