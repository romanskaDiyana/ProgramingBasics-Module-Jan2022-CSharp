using System;

namespace _05HairSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Деси има фризьорски салон в София. Тя всеки ден си поставя за
            //цел да постигне определена печалба.Напишете програма, която
            //изчислява дали е успяла да постигне целта за деня, като
            //знаете следното:
            //Деси ще приема клиенти докато не приключи работния ден.
            //Ако постигне желания приход обаче, тя ще затвори салона.
            //Когато клиент влезе ще може да си избере една от следните услуги:

            //    • Подстригване(haircut):
            //        ◦ Мъжко(mens) - 15лв.
            //        ◦ Дамско(ladies) – 20лв.
            //        ◦ Детско(kids) – 10лв.
            //    • Боядисване(color):
            //        ◦ Поддръжка(touch up) – 20лв.
            //        ◦ Пълно боядисване(full color) – 30лв.

            //Вход:
            //От конзолата първоначално се чете 1 ред:
            //    • цел за деня – цяло число в интервала[1 … 5000]

            double target = double.Parse(Console.ReadLine());

            double price = 0;

            //След това се четат поредица от редове до получаване на команда "closed" или
            //докато Деси не постигне целта за деня – услугата,
            //която иска клиентът – текст с възможности "haircut" и "color".
            //При команда "haircut" ще се очаква да се въведе видът на
            //подстригването – "mens", "ladies" или "kids".
            //При команда "color" ще се очаква видът на боядисването – "touch up" или "full color".

            string command = "";

            while (command != "closed")
            {
              
                command = Console.ReadLine();

                if (command == "haircut")
                {
                    command = Console.ReadLine();

                    if (command == "mens")
                    {
                        price += 15;
                    }
                    else if (command == "ladies")
                    {
                        price += 20;
                    }
                    else if (command == "kids")
                    {
                        price += 10;
                    }
                }
                if (command == "color")
                {
                    command = Console.ReadLine();

                    if (command == "touch up")
                    {
                        price += 20;
                    }
                    else if (command == "full color")
                    {
                        price += 30;
                    }
                }

                if (price >= target)
                {
                    break;
                }

            }

            //Изход:
            //На конзолата се отпечатват 2 реда:
            //    • На първия ред:
            //    • Ако Деси е успяла да постигне целта за деня:
            //            "You have reached your target for the day!"
            //    • Ако Деси не е успяла да постигне целта за деня:
            //"Target not reached! You need {колко пари не и достигат, за да стигне целта}lv. more."
            //    • На втория ред:
            //            "Earned money: {парите, които е спечелила за деня}lv."

            if (price>=target)
            {
                Console.WriteLine("You have reached your target for the day!");
                Console.WriteLine($"Earned money: {price}lv.");
            }
            else 
            {
                Console.WriteLine($"Target not reached! You need {target - price}lv. more.");
                Console.WriteLine($"Earned money: {price}lv.");
            }
            


        }
    }
}
