using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTrip = int.Parse(Console.ReadLine()) - 1;
            string typeOfRoom = Console.ReadLine();
            string eval = Console.ReadLine();

            double roomPrice = 18.0;
            double apartmentPrice = 25.0;
            double presidentApartmantPrice = 35.0;
            
            double priceDiscount = 1.0;
            double evalDiscount = 1.0;

            double totalPrice = 0.0;

            switch (typeOfRoom)
            {
                case "apartment":
                    if (daysOfTrip < 10)
                    {
                        priceDiscount = 0.30;
                    }
                    else if (daysOfTrip >= 10 && daysOfTrip <= 15)
                    {
                        priceDiscount = 0.35;
                    }
                    else
                    {
                        priceDiscount = 0.50;
                    }
                    totalPrice = daysOfTrip * apartmentPrice * (1 - priceDiscount);
                    break;

                case "president apartment":
                    if (daysOfTrip < 10)
                    {
                        priceDiscount = 0.10;
                    }
                    else if (daysOfTrip >= 10 && daysOfTrip <= 15)
                    {
                        priceDiscount = 0.15;
                    }
                    else
                    {
                        priceDiscount = 0.20;
                    }
                    totalPrice = daysOfTrip * presidentApartmantPrice * (1 - priceDiscount);
                    break;

                default:
                    totalPrice = daysOfTrip * roomPrice;
                    break;

            }

            if (eval == "positive")
            {
                evalDiscount = 1.25;
            }
            else
            {
                evalDiscount = 0.90;
            }

            totalPrice = totalPrice * evalDiscount;


            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
