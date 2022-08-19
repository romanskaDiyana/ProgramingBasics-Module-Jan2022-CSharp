using System;

namespace _04Walking
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //Поставила за цел да върви 10 000 стъпки всеки ден.
            //Някои дни ще
            //иска да се прибере преди да постигне целта си.
            //Напишете програма, която чете от конзолата по колко
            //стъпки изминава тя всеки път като излиза през
            //деня.


            int stepsDueDay = 0;
          
            
            

            //Ако иска да се прибере преди това, тя ще въведе командата
            //"Going home" и ще въведе стъпките, които е извървяла докато се прибира.

            while ( > 0)
            {
               string command = Console.ReadLine();

                if (command == "Going Home")
                {
                    stepsDueDay += stepsDueDay;
                    command = Console.ReadLine();
                    stepsDueDay = int.Parse(command);
                }

                stepsDueDay = int.Parse(command);

                if (goal <= 0)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($" {stepsDueDay - goal} steps over the goal!");
                    break;
                }
                
                goal -= stepsDueDay;
            }
                //След което, ако не е успяла да постигне целта си,
                //на конзолата трябва да се изпише: "{разликата между стъпките}
                //more steps to reach goal."
                
            

        }
    }
}
