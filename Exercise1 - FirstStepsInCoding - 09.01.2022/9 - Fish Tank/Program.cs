using System;

namespace _9___Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            // четем: дължина, широчина, височина, процент; 

            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            double percent = double.Parse(Console.ReadLine());

            // изчисляваме - обем на аквариум;

            double volume = lenght * width * hight;

            // изчисляваме - обем в литри;

            double voulumeLitters = volume / 1000.0;

            // изчисляваме - каква част от аквариума е заета; 

            double spaceTaken = percent / 100.0;


            // изчисляваме - колко вода трябва да се налее;

            double waterNeeded = voulumeLitters * (1 - spaceTaken);


            // печатаме - резултат на конзола; 
            Console.WriteLine(waterNeeded);
        }
    }
}
