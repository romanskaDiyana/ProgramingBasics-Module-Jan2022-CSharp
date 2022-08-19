using System;

namespace _08TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            //условие:

            //През годината Гришо участва в определен брой турнири,
            //като за всеки турнир получава точки, които зависят от позицията,
            //на която е завършил в турнира.Има три варианта за завършване на турнир:
            //    • W - ако е победител получава 2000 точки
            //    • F - ако е финалист получава 1200 точки
            //    • SF - ако е полуфиналист получава 720 точки

            //Напишете програма, която изчислява колко ще са точките на Григор след
            //изиграване на всички турнири, като знаете с колко точки стартира сезона.
            //Също изчислете колко точки средно печели от всички изиграни турнири и
            //колко процента от турнирите е спечелил.

            //Вход
            //От конзолата първо се четат два реда:
            //    • Брой турнири, в които е участвал – цяло число в интервала[1…20] 
            //    • Начален брой точки в ранглистата - цяло число в интервала[1...4000]

            int numTournament = int.Parse(Console.ReadLine());
            int pointRanglist = int.Parse(Console.ReadLine());

            //За всеки турнир се прочита отделен ред:
            //    • Достигнат етап от турнира – текст – "W", "F" или "SF"

            int totalPoints = 0;
            int wins = 0;

            for (int i = 1; i <= numTournament; i++)
            {
                string result = Console.ReadLine();

                if (result == "W")
                {
                    totalPoints += 2000;
                    wins++;
                }
                else if (result == "F")
                {
                    totalPoints += 1200;
                }
                else if (result == "SF")
                {
                    totalPoints += 720;
                }
            }            
            double averagePoints = totalPoints / numTournament;
            double winPercent = wins * 100.00 / numTournament;

            //Изход
            //Отпечатват се три реда в следния формат:
            //    • "Final points: {брой точки след изиграните турнири}"
            //    • "Average points: {средно колко точки печели за турнир}"
            //    • "{процент спечелени турнири}%"
            //Средните точки да бъдат закръглени към най - близкото цяло число надолу,
            //а процентът да се форматира до втората цифра след десетичния знак.
            Console.WriteLine($"Final points: {totalPoints + pointRanglist}");
            Console.WriteLine($"Average points: {Math.Ceiling(averagePoints)}");
            Console.WriteLine($"{winPercent:f2}%");
        }
    }
}
