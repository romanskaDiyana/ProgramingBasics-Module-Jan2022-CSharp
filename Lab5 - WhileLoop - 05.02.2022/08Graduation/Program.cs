using System;

namespace _08Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход:
            //Напишете програма, която изчислява
            //средната оценка на ученик от цялото му обучение.
            //На първия ред ще получите името на ученика,
            //а на всеки следващ ред неговите годишни оценки.
            //Ученикът преминава в следващия клас, ако годишната
            //му оценка е по-голяма или равна на 4.00. Ако ученикът
            //бъде скъсан повече от един път, то той бива изключен и
            //програмата приключва, като се отпечатва името на ученика и
            //в кой клас бива изключен.

            string name = Console.ReadLine(); //име на ученика

            int grade = 1; //класа в който се намира ученика 
            double sumYearlyGrade = 0;
            int counter = 0;

            while (grade <= 12)
            {
               double yearlyGrade = double.Parse(Console.ReadLine()); // годишна оценка

                if (yearlyGrade < 4)
                {
                    if (counter == 1)
                    {
                        break;
                    }
                    counter++;
                    continue;
                }


               sumYearlyGrade += yearlyGrade;

               grade++;
            }

          double averageGrade = sumYearlyGrade / 12;

            if (grade>12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
         
         
            
            

            // При успешно завършване на 12-ти клас да се отпечата : 
            //"{име на ученика} graduated. Average grade: {средната оценка от цялото обучение}"
            //В случай, че ученикът е изключен от училище, да се отпечата:
            //"{име на ученика} has been excluded at {класа, в който е бил изключен} grade"
            //Стойността трябва да бъде форматирана до втория знак след десетичната запетая.
        }
    }
}
