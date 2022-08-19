using System;

namespace _07AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем вида на фигурата - square, rectangle, circle или triangle
            string figure = Console.ReadLine();
            double area = 0; //създаваме 1 променлива за всички ifove!!!
            //задаваме ако: 
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = r * r * Math.PI;
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                area = a * ha / 2;
                // обединяваме в серия от проверки с else if, за да спестим на програмата преминаване;
                //промяна в кода!!!!!
            }
            else   //максимално прецизен код!!!
            {
                Console.WriteLine("Invalid input!");
            }
            if (area > 0)
            {
                Console.WriteLine($"{area:f3}"); // печат само накрая!!!!
            }   
                
    }
}