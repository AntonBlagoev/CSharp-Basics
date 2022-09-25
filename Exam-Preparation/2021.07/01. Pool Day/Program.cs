using System;

namespace _01._Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPeople = double.Parse(Console.ReadLine());
            double taxEntry = double.Parse(Console.ReadLine());
            double sunbedPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double taxEntryCosts = numberOfPeople * taxEntry;
            double sunBedCosts = Math.Ceiling((numberOfPeople * 0.75)) * sunbedPrice;
            double umbrellaCosts = Math.Ceiling(numberOfPeople / 2) * umbrellaPrice;

            double totalCosts = taxEntryCosts + sunBedCosts + umbrellaCosts;

            Console.WriteLine($"{totalCosts:f2} lv.");

        }
    }
}
