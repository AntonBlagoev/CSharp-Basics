using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double apartmentPrice = 0.0;

            double studioDiscount = 0.0;
            double apartmentDiscount = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50.0;
                apartmentPrice = 65.0;

                if (nights > 14)
                {
                    studioDiscount = 0.3;
                    apartmentDiscount = 0.1;
                }
                else if (nights > 7)
                {
                    studioDiscount = 0.05;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;

                if (nights > 14)
                {
                    studioDiscount = 0.2;
                    apartmentDiscount = 0.1;
                }
                
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76.0;
                apartmentPrice = 77.0;

                if (nights > 14)
                {
                    apartmentDiscount = 0.1;
                }
            }

            
           

            double studioTotalPrice = nights * (studioPrice * (1 - studioDiscount));
            double apartmentTotalPrice = nights * (apartmentPrice * (1 - apartmentDiscount));


            Console.WriteLine($"Apartment: {apartmentTotalPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioTotalPrice:f2} lv.");
        }
    }
}
