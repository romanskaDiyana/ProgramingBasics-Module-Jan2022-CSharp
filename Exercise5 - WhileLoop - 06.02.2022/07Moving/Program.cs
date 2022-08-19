using System;

namespace _07Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която изчислява свободния обем от жилището на Хосе, който остава след като пренесе багажа си.
            //Бележка: Един кашон е с точни размери:  1m.x 1m.x 1m.

            //Вход
            //Потребителят въвежда следните данни на отделни редове:
            //    1.Широчина на свободното пространство - цяло число в интервала[1...1000]
            //    2.Дължина на свободното пространство - цяло число в интервала[1...1000]
            //    3.Височина на свободното пространство - цяло число в интервала[1...1000]

            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeSpace = width * height * lenght;

            string command = "";
            int boxesNum = 0;

            //На следващите редове(до получаване на команда "Done") - брой кашони, които се пренасят в квартирата - цяло число в интервала[1...10000]
            //Програмата трябва да приключи прочитането на данни при команда "Done" или ако свободното място свърши.

            while (freeSpace > 0)
            {
                command = Console.ReadLine();

                if (command == "Done")
                {                    
                        Console.WriteLine($"{freeSpace} Cubic meters left.");
                        break;
                }

                boxesNum = int.Parse(command);

                if (boxesNum > freeSpace)
                {
                    Console.WriteLine($"No more free space! You need {boxesNum - freeSpace} Cubic meters more.");
                    break;
                }

                freeSpace -= boxesNum;
            }


            //Изход
            //Да се отпечата на конзолата един от следните редове:
            //    • Ако стигнете до командата "Done" и има още свободно място:
            //            "{брой свободни куб. метри} Cubic meters left."
            //    • Ако свободното място свърши преди да е дошла команда "Done":
            //"No more free space! You need {брой недостигащи куб. метри} Cubic meters more."
        }
    }
}
