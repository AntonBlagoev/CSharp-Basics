using System;

namespace _02._Task
{
    class Program
    {
        static void Main(string[] args)
        {

            double partyPrice = double.Parse(Console.ReadLine());
            double messageNumber = double.Parse(Console.ReadLine());
            double rossesNumber = double.Parse(Console.ReadLine());
            double keysNumber = double.Parse(Console.ReadLine());
            double cartoonsNumber = double.Parse(Console.ReadLine());
            double luckysNumber = double.Parse(Console.ReadLine());

           
            double profit = messageNumber * 0.60 + rossesNumber * 7.20 + keysNumber * 3.60 + cartoonsNumber * 18.20 + luckysNumber * 22;
            double allNumbers = messageNumber + rossesNumber + keysNumber + cartoonsNumber + luckysNumber;

            if (allNumbers >= 25)
            {
                profit = profit * 0.65;
            }

            // Hosting costs

            profit = profit * 0.9;

            if (profit >= partyPrice)
            {
                Console.WriteLine($"Yes! {profit - partyPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {partyPrice - profit:f2} lv needed.");
            }


        }
    }
}
