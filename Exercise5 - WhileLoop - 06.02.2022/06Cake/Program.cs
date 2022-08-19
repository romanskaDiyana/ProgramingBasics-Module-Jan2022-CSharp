using System;

namespace _06Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            //условие:
            //Вашата задача е да напишете програма,
            //която изчислява броя на парчетата, които гостите са взели,
            //преди тя да свърши.


            //Бележка: Едно парче торта е с размер 1х1 см!!!!
            //вход:
            //Ще получите размерите на тортата
            //широчина и дължина – цели числа в интервала[1...1000]

            int lengthCake = int.Parse(Console.ReadLine()); //10 
            int widthCake = int.Parse(Console.ReadLine()); //10

            int pieceSum = lengthCake * widthCake; //100
     
            string command = "";

            int  pieceNum = 0;
            //и след това на всеки ред, до получаване на командата "STOP"или докато не свърши тортата, броят на парчетата, които гостите вземат от нея.
            while (pieceSum > 0)
            {
                command = Console.ReadLine();
                
              
                if (command == "STOP")
                {
                    if (pieceSum > 0)
                    {
                        Console.WriteLine($"{pieceSum} pieces are left.");
                        break;
                    }
                }

                pieceNum = int.Parse(command);

                if (pieceNum > pieceSum)
                {
                    Console.WriteLine($"No more cake left! You need {pieceNum- pieceSum} pieces more.");
                    break;
                }

                pieceSum -= pieceNum;
            }

            //изход:
            //Да се отпечата на конзолата един от следните редове:
            //"{брой парчета} pieces are left." - ако стигнете до STOP и не са свършили парчетата торта
            //"No more cake left! You need {брой недостигащи парчета} pieces more."
        }
    }
}
