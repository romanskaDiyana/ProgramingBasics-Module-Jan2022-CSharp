using System;

namespace _06Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход:
            //    • Име на актьора - текст
            //Точки от академията - реално число в интервала[2.0... 450.5]
            //Брой оценяващи n - цяло число в интервала[1… 20]

            string nameActor = Console.ReadLine();
            double pointAcademy = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            //На следващите n - на брой реда:
            //Име на оценяващия - текст
            //Точки от оценяващия - реално число в интервала[1.0... 50.0]

            //Условие:
            // Поканени сте от академията да напишете софтуер, който да пресмята
            // точките за актьор/ актриса.Академията ще ви даде първоначални точки
            // за актьора.След това всеки оценяващ ще дава своята оценка.
            // Точките, които актьора получава се формират от: дължината на
            // името на оценяващия умножено по точките, които дава делено на две. 
            //Ако резултатът в някой момент надхвърли 1250.5 програмата трябва
            //да прекъсне и да се отпечата, че дадения актьор е получил номинация.
            //На следващите n - на брой реда:
            for (int i = 1; i <= judges; i++)
            {
                string nameJudges = Console.ReadLine();
                double pointsJudges = double.Parse(Console.ReadLine());

                pointAcademy += nameJudges.Length * pointsJudges / 2;

                if (pointAcademy >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {pointAcademy:f1}!");
                    break;
                }
            }
            //Изход:
            //Ако точките са над 1250.5:
            //"Congratulations, {име на актьора} got a nominee for leading role with {точки}!"
            //Ако точките не са достатъчни:
            //"Sorry, {име на актьора} you need {нужни точки} more!"
            //Резултатът да се форматирана до първата цифра след десетичния знак!
            if (pointAcademy < 1250.5)
            {
                Console.WriteLine($"Sorry, {nameActor} you need {1250.5-pointAcademy:f1} more!");
            }
        }
    }
}
