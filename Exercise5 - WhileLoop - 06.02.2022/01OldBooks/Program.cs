using System;

namespace _01OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            //условие:
            //Помогнете на Ани, като напишете
            //програма в която тя въвежда търсената от нея книга(текст).
            //Докато Ани не намери любимата си книга или не провери всички
            //в библиотеката, програмата трябва да чете всеки път на нов ред
            //името на всяка следваща книга (текст). Книгите в библиотеката
            //са свършили щом получите текст "No More Books".

            //запазваме любимата книга на Ани:

            string favouriteBook = Console.ReadLine();

            int counterBook = 0; //тук ще пазим, броя книги, които сме пегледали в търсене на любимата;

            string input = Console.ReadLine();


            //цикъл, в който всеки път ще четем нова книга
            //=> докато не минем през всички книги (No More Books)
            //=> докато не намерим книгата; 
            while (input != "No More Books")
            {
                if (input == favouriteBook)
                {
                    break;
                }
                counterBook++;
                input = Console.ReadLine();
            }
            //Ако открие книгата си се отпечатва един ред:
            //"You checked {брой} books and found it.
            if (input== favouriteBook)
            {
                Console.WriteLine($"You checked {counterBook} books and found it.");
            }

            //Ако не открие търсената книгата да се отпечата на два реда:
            //"The book you search is not here!"
            //"You checked {брой} books."
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counterBook} books.");
            }
        }
    }
}
