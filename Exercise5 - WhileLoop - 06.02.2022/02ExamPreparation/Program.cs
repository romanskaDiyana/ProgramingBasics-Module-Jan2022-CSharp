using System;

namespace _02ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //условие:
            //Напишете програма, в която Марин решава задачи
            //от изпити докато не получи съобщение "Enough" от лектора си.
            //При всяка решена задача той получава оценка. Програмата трябва да приключи прочитането
            //на данни при команда "Enough" или ако
            //Марин получи определения брой незадоволителни оценки.
            //Незадоволителна е всяка оценка, която е по-малка или равна на 4.

            //вход:
            //На първи ред - брой незадоволителни оценки - цяло число в интервала [1…5]

            int failedGrades = int.Parse(Console.ReadLine());

            // - сбор на всички оценки
            // - броя на всички задачи
            // - текущо име на задача
            // - оценка от текущата задача
            // - брояч за незадоволителни оценки, които е получил до момента <=4

            double gradesSum = 0;
            double gradesCount = 0;
            string lastExercise = "";
            int grade = 0;
            int counterFailed = 0;

            //в while цикъла:
            string input = Console.ReadLine();
            while (input != "Enough") // => докато "Enough"
            {
                grade = int.Parse(Console.ReadLine()); //Оценка - цяло число в интервала[2…6]
                input = lastExercise;  //Име на задача - текст(низ)

                gradesSum += grade;
                gradesCount++;


                if (grade <=4 ) 
                {
                    counterFailed++;
                    if (failedGrades == counterFailed) // => докато брояча не стигне failedGrades;
                    {
                        //Ако получи определеният брой незадоволителни оценки:
                        //"You need a break, {брой незадоволителни оценки} poor grades."
                        //Средната оценка да бъде форматирана до втория знак след десетичната запетая.

                        Console.WriteLine($"You need a break, {counterFailed} poor grades.");
                        break;
                    }
                }
                input = Console.ReadLine();

            }
            //изход:

            //Ако Марин стигне до командата "Enough", отпечатайте на 3 реда: 

            //"Average score: {средна оценка}" => сбор от всички оценки + брой оценки
            //"Number of problems: {броя на всички задачи}"
            //"Last problem: {името на последната задача}"

            double sumAverage = gradesSum / gradesCount;

            if (failedGrades != counterFailed)
            {
                Console.WriteLine($"Average score: {sumAverage:f2}");
                Console.WriteLine($"Number of problems: {gradesCount}");
                Console.WriteLine($"Last problem: {lastExercise}");

            }
        }
    }
}
