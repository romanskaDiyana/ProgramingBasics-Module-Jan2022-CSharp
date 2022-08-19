using System;

namespace _02Password
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход
            //Напишете програма, която първоначално прочита име и парола на потребителски профил. След това чете парола за вход.
            //при въвеждане на грешна парола: потребителя да се подкани да въведе нова парола.
            //при въвеждане на правилна парола: отпечатваме "Welcome {username}!".

            string usernameDeff = Console.ReadLine();
            string passwordDeff = Console.ReadLine();

            

            int counter = 0;


            string passwordAttempt = Console.ReadLine();

            while (passwordAttempt != passwordDeff)
            {
                counter++;

                if (counter == 3)  //ЗАДЪЛЖИТЕЛНО 
                {
                    break; //прекъсване на цикъл; АКО В КОНСТРУКЦИЯТА ИМА SWITCH BREAK ЩЕ ПРИКЛЮЧИ SWITCH;
                }
                passwordAttempt = Console.ReadLine();                               
            }
            if (passwordAttempt== passwordDeff)
            {
                Console.WriteLine($"Welcome {usernameDeff}!");
            }
            else
            {
                Console.WriteLine($"Wrong password,{usernameDeff}!");
            }
            
        }
    }
}
