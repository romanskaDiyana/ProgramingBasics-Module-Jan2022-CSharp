using System;

namespace _02NumbersN1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int promenlivaforotkoqtosestrartira = number; promenlivaforotkoqtosestrartira >= 1; promenlivaforotkoqtosestrartira--)
            {
                Console.WriteLine(promenlivaforotkoqtosestrartira);  //когато е от по-голямо по-малко и е с вход - променливата във фор = промеливата int; 
            }


            int number1 = int.Parse(Console.ReadLine());

            int counter = number1;

            for (; counter >= 1;)
            {
                Console.WriteLine(counter);
            }

            counter--;

        }
    }
}
