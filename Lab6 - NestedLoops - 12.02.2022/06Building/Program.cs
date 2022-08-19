using System;

namespace _06Building
{
    class Program
    {
        static void Main(string[] args)
        {
            //условие:
            //Напишете програма, която извежда на конзолата номерата
            //на стаите в една сграда (в низходящ ред), като са
            //изпълнени следните условия:

            //На всеки четен етаж има само офиси
            //На всеки нечетен етаж има само апартаменти
            //Всеки апартамент се означава по следния начин: А{ номер на етажа}
            //{ номер на апартамента}, номерата на апартаментите започват от 0.
            //Всеки офис се означава по следния начин: О{ номер на етажа}
            //{ номер на офиса}, номерата на офисите също започват от 0.
            //На последният етаж винаги има апартаменти и те са по-големи
            //от останалите, за това пред номера им пише 'L', вместо 'А'.
            //Ако има само един етаж, то има само големи апартаменти!



            //вход:
            //От конзолата се прочитат
            //две цели числа - броят на етажите и
            //броят на стаите за един етаж.

            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int floorLoop = floors; floorLoop > 0; floorLoop--)
            {

                for (int roomLoop = 0; roomLoop < rooms; roomLoop++)
                {
                    if (floorLoop == floors)
                    {
                        Console.Write($"L{floorLoop}{roomLoop} ");
                    }
                    else if (floorLoop % 2 == 0)
                    {
                        Console.Write($"O{floorLoop}{roomLoop} ");
                    }
                    else
                    {
                        Console.Write($"A{floorLoop}{roomLoop} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}






