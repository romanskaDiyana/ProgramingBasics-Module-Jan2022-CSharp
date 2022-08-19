using System;

namespace _03PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем парола - текст 
            string password = Console.ReadLine();
            //задаваме ако:
            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else 
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
