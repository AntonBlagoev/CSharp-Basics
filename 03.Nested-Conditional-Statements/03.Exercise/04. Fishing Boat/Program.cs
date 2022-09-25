using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishersNumber = int.Parse(Console.ReadLine());

            double rentPrice = 0.0;
            double discount = 1.0;
            double extraDiscount = 1.0;
           

            if (season == "Spring")
            {
                rentPrice = 3000.0;
                if(fishersNumber % 2 == 0)
                {
                    extraDiscount = 0.95;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rentPrice = 4200.0;
                if (season == "Summer" && fishersNumber % 2 == 0)
                {
                    extraDiscount = 0.95;
                }
            }
            else if (season == "Winter")
            {
                rentPrice = 2600.0;
                if (fishersNumber % 2 == 0)
                {
                    extraDiscount = 0.95;
                }
            }

            if (fishersNumber <= 6)
            {
                discount = 0.9;
            }
            else if (fishersNumber >= 7 && fishersNumber <= 11)
            {
                discount = 0.85;
            }
            else if (fishersNumber >= 12)
            {
                discount = 0.75;
            }

            double totalPrice = (rentPrice * discount) * extraDiscount;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:F2} leva.");
            }
        }
    }
}
