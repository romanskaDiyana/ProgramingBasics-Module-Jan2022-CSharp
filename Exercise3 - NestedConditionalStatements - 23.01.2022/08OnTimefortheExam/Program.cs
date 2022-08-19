using System;

namespace _08OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //10:00
            int examHour = int.Parse(Console.ReadLine()); //10
            int examMin = int.Parse(Console.ReadLine()); //00

            //9:50
            int arrivalHour = int.Parse(Console.ReadLine()); //9
            int arrivalMin = int.Parse(Console.ReadLine());//50

            //преобразуваме часове в минути:
            examMin = examMin + (examHour * 60); //600
            arrivalMin = arrivalMin + (arrivalHour * 60); //590

            //    • “Late” => arrivalMin > examMin;
            //    • “On time” => arrivalMin = examMin; || => arrivalMin - examMin <= 30; или до 30 мин;
            //    • “Early”, arrivalMin - examMin >= 30; над 30 мин;
            //     Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
            //     “mm minutes after the start” за закъснение под час.
            //    • “hh: mm hours after the start” за закъснение от 1 час или повече.Минутите винаги печатайте с 2 цифри, например “1:03”.

            //намираме разлика във времето на пристигане:
            int difference = arrivalMin - examMin; //590-600 = -10

            //намираме разликата в часове и минути:
            int diffHour = difference / 60; // -10/60 = 0
            int diffMin = difference % 60; // -10

            if (examMin < arrivalMin) //Late 600>590 - false
            {
                Console.WriteLine("Late");
                if (diffHour >= 1) // проверяваме дали закъснява с повече от 1 час:
                {
                    if (diffMin < 10) // ако закъснява с повече от 1 час, проверяваме дали минутите са по-малко от 10, ако са по-малко печатаме с водеща нула;
                    {
                        Console.WriteLine($"{diffHour}:0{diffMin} hours after the start");

                    }
                    else
                    {
                        Console.WriteLine($"{diffHour}:{diffMin} hours after the start");

                    }

                }
                else
                {
                    Console.WriteLine($"{diffMin} minutes after the start");
                }


            }
            else if (examMin - arrivalMin <= 30) //On time 600-590 - true
            {
                Console.WriteLine("On time");

                if (examMin != arrivalMin) //600=!590 - true
                {
                    
                    Console.WriteLine($"{Math.Abs(difference)} minutes before the start");
                }

            }
            else if (examMin - arrivalMin > 30) // Early
            {

                if (examMin > arrivalMin) 
                {
                    Console.WriteLine("Early");

                    //намираме разлика във времето на пристигане:

                    difference = examMin - arrivalMin;

                    //намираме разликата в часове и минути:
                    diffHour = Math.Abs(diffHour);
                    diffMin = Math.Abs(diffMin);

                    if (diffHour >= 1) // проверяваме дали подранява с повече от 1 час:
                    {
                        if (diffMin < 10) // ако е с повече от 1 час, проверяваме дали минутите са по-малко от 10, ако са по-малко печатаме с водеща нула;
                        {
                            Console.WriteLine($"{diffHour}:0{diffMin} hours before the start");

                        }
                        else
                        {
                            Console.WriteLine($"{diffHour}:{diffMin} hours before the start");

                        }

                    }
                    else
                    {
                        Console.WriteLine($"{diffMin} minutes before the start");
                    }
                }
            }
        }
    }
}
