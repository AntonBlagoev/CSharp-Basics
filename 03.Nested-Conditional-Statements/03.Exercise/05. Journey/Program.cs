using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination;
            string vacation = "Vacation";

            double costs = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    costs = budget * 0.3;
                    vacation = "Camp";
                }
                else if (season == "winter")
                {
                    costs = budget * 0.7;
                    vacation = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    costs = budget * 0.4;
                    vacation = "Camp";
                }
                else if (season == "winter")
                {
                    costs = budget * 0.8;
                    vacation = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                costs = budget * 0.9;
                vacation = "Hotel";
               
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacation} - {costs:f2}");
        }
    }
}
