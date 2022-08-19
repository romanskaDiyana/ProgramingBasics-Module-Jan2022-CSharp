using System;

namespace _05Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход:
            //Брой отворени табове в браузъра n - цяло число в интервала [1...10]
            //Заплата - число в интервала[500...1500]

            int numberTabs = int.Parse(Console.ReadLine()); 
            int salary = int.Parse(Console.ReadLine());

            int penalty = 0;

            //условие:
            //Шеф на компания забелязва че все повече служители прекарват
            //време в сайтове, които ги разсейват.  
            //За да предотврати това, той въвежда изненадващи
            //проверки на отворените табове на браузъра на служителите си.
            //Според отворения сайт в таба се налагат следните глоби:
            //"Facebook"-> 150 лв.
            //"Instagram"-> 100 лв.
            //"Reddit"-> 50 лв.

            for (int i = 1; i <= numberTabs; i++)
            {
                string site = Console.ReadLine();
                if (site == "Facebook")
                {
                    penalty += 150;
                }
                else if (site == "Instagram")
                {
                    penalty += 100;
                }
                else if (site == "Reddit")
                {
                    penalty += 50;
                }

                if (penalty >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    break; //СПИРАНЕ НА ЦИКЪЛ!!!!
                }
                     
            }

            if (penalty < salary)
            {
                Console.WriteLine($"{salary- penalty}");
            }



            //изход:
            //Ако по време на проверката заплатата стане по-малка или равна на 0 лева, на конзолата се изписва 
            //"You have lost your salary." и програмата приключва.
            //В противен случай след проверката на конзолата се изписва остатъкът от заплатата(да се изпише като цяло число).

        }
    }
}
