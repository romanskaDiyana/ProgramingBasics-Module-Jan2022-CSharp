using System;

namespace _03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //условие:
            //Джеси е решила да събира пари за екскурзия и
            //иска от вас да ѝ помогнете да разбере дали ще
            //успее да събере необходимата сума.
            //Тя спестява или харчи част от парите си всеки ден.
            //Ако иска да похарчи повече от наличните си пари,
            //то тя ще похарчи колкото има и ще ѝ останат 0 лева.

            //вход:
            //Пари нужни за екскурзията - реално число в интервала [1.00...25000.00]
            //Налични пари -реално число в интервала[0.00...25000.00]

            double neededMoney = double.Parse(Console.ReadLine()); //сума необходима за почивка
            double availableMoney = double.Parse(Console.ReadLine()); // налични пари

            //След това многократно се четат по два реда:
            //Вид действие – текст с възможности "spend" и "save"
            //Сумата, която ще спести / похарчи - реално число в интервала[0.01… 25000.00]

            string input = ""; // видът действие, spend/save
            double sum = 0;// обща сума 

            int daysCount = 0; //брой изминали дни
            int spendCountDays = 0; //поредни дни в който харчи пари; 

            while (availableMoney < neededMoney)
            {
                input = Console.ReadLine(); // видът действие, spend/save
                sum = double.Parse(Console.ReadLine()); // обща сума 
                daysCount++;

                if (input == "save")
                {
                    availableMoney += sum;
                    spendCountDays = 0; //зачита само 5 последователни дни!!!!!
                }
                else
                {
                    availableMoney -= sum;
                    spendCountDays++;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }

                }

                if (spendCountDays >= 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{daysCount}");
                    break;
                }
                //изход:
                // Програмата трябва да приключи при следните случаи:
                //Ако 5 последователни дни Джеси само харчи, на конзолата да се изпише:
                //"You can't save the money."
                //"{Общ брой изминали дни}"
                // Ако Джеси събере парите за почивката на конзолата се изписва:
                // "You saved the money for {общ брой изминали дни} days."

                if (availableMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {daysCount} days.");

                }
            }
        }
    }
}
