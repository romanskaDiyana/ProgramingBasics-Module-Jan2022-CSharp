using System;

namespace _07HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем от конзолата:
            string month = Console.ReadLine(); //May, June, July, August, September или October
            int numNights = int.Parse(Console.ReadLine());


            double studioPrice = 0;
            double apartmentPrice = 0;


            //да се намерии цената за целия престой за студио и апартамент
            //Цената зависи от месеца:
            //               Май и октомври:
            //Студио – 50 лв./ нощувка
            //Апартамент – 65 лв./ нощувка
            //               Юни и септември:
            //Студио – 75.20 лв./нощувка
            //Апартамент – 68.70 лв./ нощувка
            //               Юли и август:
            //Студио – 76 лв./нощувка
            //Апартамент – 77 лв./ нощувка

            //• За студио, при повече от 7 нощувки през май и октомври : 5% намаление.
            //• За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
            //• За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
            //• За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.

            if (month == "May" || month == "October")
            {
                studioPrice = numNights * 50;
                apartmentPrice = numNights * 65;

                if (numNights > 14)
                {
                    studioPrice = studioPrice - studioPrice * 0.3;
                    apartmentPrice = apartmentPrice - apartmentPrice * 0.10;
                }
                else if (numNights > 7 && numNights <= 14)
                {
                    studioPrice = studioPrice - studioPrice * 0.05;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = numNights * 75.20;
                apartmentPrice = numNights * 68.70;

                if (numNights > 14)
                {
                    studioPrice = studioPrice - studioPrice * 0.2;
                    apartmentPrice = apartmentPrice - apartmentPrice * 0.10;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = numNights * 76;
                apartmentPrice = numNights * 77;

                if (numNights > 14)
                {
                    apartmentPrice = apartmentPrice - apartmentPrice * 0.10;
                }
            }

            //            Да се отпечатат на конзолата 2 реда:
            //    • На първия ред: “Apartment: { цена за целият престой}
            //            lv.”
            //    • На втория ред: “Studio: { цена за целият престой}
            //            lv.“
            //Цената за целия престой форматирана с точност до два знака след десетичната запетая.

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
