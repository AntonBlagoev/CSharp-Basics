using System;

namespace _02._Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nightsNumber = int.Parse(Console.ReadLine());
            double nightsPrice = double.Parse(Console.ReadLine());
            double addCosts = budget * (double.Parse(Console.ReadLine()) / 100);

            double discount = 1.0;

            if (nightsNumber > 7 )
            {
                discount = 0.95;
            }

            double totalCosts = (nightsNumber * (nightsPrice * discount)) + addCosts;

            if (budget >= totalCosts)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - totalCosts:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalCosts - budget:f2} leva needed.");
            }
        }
    }
}
