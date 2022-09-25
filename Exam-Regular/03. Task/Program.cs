using System;

namespace _03._Task
{
    class Program
    {
        static void Main(string[] args)
        {

            double dancers = double.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string seasson = Console.ReadLine();
            string place = Console.ReadLine();

            double costs = 0.0;
            double addMoney = 1.0;

            if (seasson == "summer")
            {
                if (place == "Bulgaria")
                {
                    costs = 0.95;
                }
                else if (place == "Abroad")
                {
                    costs = 0.9;
                    addMoney = 1.5;
                }
            }
            else if (seasson == "winter")
            {
                if (place == "Bulgaria")
                {
                    costs = 0.92;
                }
                else if (place == "Abroad")
                {
                    costs = 0.85;
                    addMoney = 1.5;
                }
            }


            double award = ((dancers * points) * addMoney) * costs;
            double charity = award * 0.75;
            double moneyPerDancer = (award - charity) / dancers;

            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:f2}");


        }
    }
}
