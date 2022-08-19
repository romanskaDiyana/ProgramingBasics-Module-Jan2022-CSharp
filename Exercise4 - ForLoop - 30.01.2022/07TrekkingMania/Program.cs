using System;

namespace _07TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            //условие:
            //Да се напише програма, която изчислява процента
            //на катерачите изкачващи всеки връх.
            //Според размера на групата, катерачите ще изкачват
            //различни върхове.
            //• Група до 5 човека – изкачват Мусала
            //• Група от 6 до 12 човека – изкачват Монблан
            //• Група от 13 до 25 човека – изкачват Килиманджаро
            //• Група от 26 до 40 човека –  изкачват К2
            //• Група от 41 или повече човека – изкачват Еверест
            //вход:
            //От конзолата се четат поредица от числа, всяко на отделен ред:
            //На първия ред – броя на групите от катерачи – цяло число в интервала[1...1000]
            //За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала[1...1000]
            int groupNumber = int.Parse(Console.ReadLine());

            double group1 = 0;
            double group2 = 0;
            double group3 = 0;
            double group4 = 0;
            double group5 = 0;

            for (int i = 1; i <= groupNumber; i++)
            {
                int peopleNum = int.Parse(Console.ReadLine());

                if (peopleNum <= 5 )
                {
                    group1 += peopleNum;
                }
                else if (peopleNum <= 12)
                {
                    group2 += peopleNum;
                }
                else if (peopleNum <=25 )
                {
                    group3 += peopleNum;
                }
                else if (peopleNum <= 40)
                {
                    group4 += peopleNum;
                }
                else  
                {
                    group5 += peopleNum;
                }
            }
            double totalNumPeople = group1 + group2 + group3 + group4 + group5;

            double group1Percent = group1 / totalNumPeople * 100.00;
            double group2Percent = group2 / totalNumPeople * 100.00;
            double group3Percent = group3 / totalNumPeople * 100.00;
            double group4Percent = group4 / totalNumPeople * 100.00;
            double group5Percent = group5 / totalNumPeople * 100.00;

            //изход:
            //Да се отпечатат на конзолата 5 реда, всеки от които съдържа
            //процент между 0.00 % и 100.00 % с точност до втората цифра
            //след десетичната запетая.
            //• Първи ред -процентът изкачващи Мусала
            //• Втори ред – процентът изкачващи Монблан
            //• Трети ред – процентът изкачващи Килиманджаро
            //• Четвърти ред – процентът изкачващи К2
            //• Пети ред – процентът изкачващи Еверест
            Console.WriteLine($"{group1Percent:f2}%");
            Console.WriteLine($"{group2Percent:f2}%");
            Console.WriteLine($"{group3Percent:f2}%");
            Console.WriteLine($"{group4Percent:f2}%");
            Console.WriteLine($"{group5Percent:f2}%");          
        }
    }
}
