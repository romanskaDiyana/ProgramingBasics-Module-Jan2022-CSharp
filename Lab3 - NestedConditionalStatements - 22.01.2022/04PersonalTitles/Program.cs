using System;

namespace _04PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем входни данни - години и пол;
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            //залагаме if за пол; 
            if (gender == 'f')
            { // в пола залагаме if за години;
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
            else if (gender == 'm')
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else 
                {
                    Console.WriteLine("Mr.");
                }
        }
    }
}
