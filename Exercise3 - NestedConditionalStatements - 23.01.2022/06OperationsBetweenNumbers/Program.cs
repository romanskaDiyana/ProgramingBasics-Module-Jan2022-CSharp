using System;

namespace _06OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            char operate = char.Parse(Console.ReadLine()); //каква математическа операция се извършва

            double result = 0; //резултат от математическа операция

            if (operate == '+' || operate == '-' || operate == '*')
            {
                if (operate == '+')
                {
                    result = number1 + number2;
                }
                else if (operate == '-')
                {
                    result = number1 - number2;
                }
                else // остава само *
                {
                    result = number1 * number2;
                }

                string evenOrOdd = "odd";

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }

                Console.WriteLine($"{number1} {operate} {number2} = {result} - {evenOrOdd}");


            }
            else //operate = / || %
            {
                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    if (operate == '/')
                    {
                        result = (double)number1 / number2; //за да получим дробно число!!

                        Console.WriteLine($"{number1} {operate} {number2} = {result:f2}");
                    }
                    else if (operate == '%')
                    {
                        result = number1 % number2;

                        Console.WriteLine($"{number1} {operate} {number2} = {result}");
                    }
                }
            }
        }
    }
}