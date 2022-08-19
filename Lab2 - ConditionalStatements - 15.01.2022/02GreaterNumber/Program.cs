using System;

namespace _02GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем 2 числа 
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            //сравняваме кое е по-голямото

            //firstNumber > secondNumber
            //firstNumber < secondNumber
            //firstNumber = secondNumber

            if (firstNumber > secondNumber)
            { //печатаме
                Console.WriteLine(firstNumber);
            }
            else 
            {
                Console.WriteLine(secondNumber);
            }

           //Debugger - ДЕБЪГВАНЕ!!!!
           //breakpoint - точка в която програмата спира! - кликаме или с f9 на реда:
           //пускане на програма - дебъгване!!! - F5 -  Debug - Start Debugging
           //Locals - какви променливи сме използвали;
           //с курсора на жълтото поле ни дава резултата;
           //продължаване с изпъление - step into, step over - F11 - step into
           //да проследим кода и къде е грешката; - f5, f11



        }
    }
}
