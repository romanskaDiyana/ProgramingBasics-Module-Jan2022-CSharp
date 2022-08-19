using System;

namespace L2901
{
    class Program
    {
        static void Main(string[] args)
        {
            //преинкрементиране на стойността 

            // int a = 5;

            // a = a + 1; // = 6

            // a += 1; // = 6

            // a++; // = 6

            // ++a; // = 6

            //Console.WriteLine(++a); = 6

            //постинкрементация
            // Console.WriteLine(a++); = 5 ???? - това къде стоят + означава кое първо ще се изпълни!
            // първо отпечатва а след това увеличава, тя се увеличава в паметта;

            //предекрементация с -


            //give me 5 waffles 

            //for (int counter = 0; counter <=5; counter++)
            //       1 създаване на      2          4 увеличава 
            //           брояч         проверка     стойността
            //                        
            //
            //  Console.WriteLine("Waffle"); //итерация 
            //               3 печат 
            // цикъла продължава докато булевия израз (2) е TRUE



            //цикъл:

            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);

            // for (int i = 1; i <= 5; i++) //може променливата да бъде и отгоре;
            //
            //  Console.WriteLine(i);
            //

            //int i = 1; //дефинираме променлива;
            //for (; i <= 5;) //проверка на условие;

            //Console.WriteLine(i); //изпълнява;
            //i++; // увеличава стойността;

            // int number = int.Parse(Console.ReadLine());

            // for (int i = number; i >= 1; i--)

            //  Console.WriteLine(i);

            //с две промеливи:

            // int number = int.Parse(Console.ReadLine());

            //for (int i = number, j = 15; i >= 1 && j <= 5; i--, j--)

            //   Console.WriteLine(i+j); //с две промеливи

            //през 3: 

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i+=5)

            // Console.WriteLine(i);


            // 2 повдигаме на четна степен:

            // int n = int.Parse(Console.ReadLine());

            // да отпечатаме всички числа до N от 0

            //for (int power = 0; power <= n ; power++) //ctrl + RR

            //if (power % 2 == 0)

            // Console.WriteLine(Math.Pow(2, power));


            //int n = int.Parse(Console.ReadLine());

            //for (int power = 0; power <= n; power += 2) //ctrl + RR

            // if (power % 2 == 0)

            //     Console.WriteLine(Math.Pow(2, power));



            //работа с текст:

            //string text = "SoftUni";


            //index - zero based index - защото започват от 0; до дължината на стринта -1;

            //Console.WriteLine(text[0]) ;

            //Console.WriteLine(text.Length - 1); //последният символ;

            //Console.WriteLine(text.Length); //property - искам да ми дадеш дължината на този текст



            //string text = Console.ReadLine();

            //int sum = 0;

            ////for (int i = 0; i < text.Length; i++)
            //{
            //   // char currentSymbol = text[i];
            //   // switch (currentSymbol)
            //    //{
            //        case 'a':
            //            sum++;
            //            break;
            //        case 'e':
            //            sum += 2;
            //            break;
            //        case 'i':
            //            sum += 3;
            //            break;
            //        case 'o':
            //            sum += 4;
            //            break;
            //        case 'u':
            //            sum += 5;
            //            break;
            //  }
            //}

            //Console.WriteLine(sum);


            //int n = int.Parse(Console.ReadLine());

            //int sum = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());

            //    sum += num;
            //}

            //Console.WriteLine(sum);


            //int number = int.Parse(Console.ReadLine());

            //int maxNum = int.MinValue;

            //for (int i = 0; i < number; i++)
            //{
            //    int currentNum = int.Parse(Console.ReadLine());

            //    if (currentNum > maxNum)
            //    {
            //        maxNum = currentNum;
            //    }
            //}

            //Console.WriteLine(maxNum);

        }
    }
}
