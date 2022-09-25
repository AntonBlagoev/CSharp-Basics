using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzelNumbers = int.Parse(Console.ReadLine());
            int dollNumbers = int.Parse(Console.ReadLine());
            int bearNumbers = int.Parse(Console.ReadLine());
            int minionNumbers = int.Parse(Console.ReadLine());
            int truckNumbers = int.Parse(Console.ReadLine());
            
            int totalNumbers = puzzelNumbers + dollNumbers + bearNumbers + minionNumbers + truckNumbers;

            double puzzelPrice = 2.60 * puzzelNumbers;
            double dolllPrice = 3 * dollNumbers;
            double bearlPrice = 4.10 * bearNumbers;
            double minionPrice = 8.20 * minionNumbers;
            double truckPrice = 2 * truckNumbers;

            double discount = 0.25;
            double rent = 0.1;
            double profit = 0;

            double totalPrice = puzzelPrice + dolllPrice + bearlPrice + minionPrice + truckPrice;
                       

            if (totalNumbers >= 50)
            {
                profit = (totalPrice - (totalPrice * discount)) - ((totalPrice - (totalPrice * discount)) * rent);
            }
            else
            {
                profit = totalPrice - (totalPrice * rent);
            }

            if (profit >= tripPrice)
            {
                Console.WriteLine($"Yes! {profit - tripPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - profit:F2} lv needed.");
            }
        }
    }
}
