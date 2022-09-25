using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocardNumber = int.Parse(Console.ReadLine());
            int processorNumber = int.Parse(Console.ReadLine());
            int ramNumber = int.Parse(Console.ReadLine());

            double videocardPrice = videocardNumber * 250.00;
            double processorPrice = processorNumber * (videocardPrice * 0.35);
            double ramPrice = ramNumber * (videocardPrice * 0.10);

            double discount = 0;

            if (videocardNumber > processorNumber)
            {
                discount = 0.15;
            }

            double costs = (videocardPrice + processorPrice + ramPrice) - ((videocardPrice + processorPrice + ramPrice) * discount);

            if (budget >= costs)
            {
                Console.WriteLine($"You have {budget - costs:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {costs - budget:F2} leva more!");
            }

        }
    }
}
