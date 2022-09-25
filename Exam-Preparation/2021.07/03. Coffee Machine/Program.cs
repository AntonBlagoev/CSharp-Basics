using System;

namespace _03._Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            double numberOfDrinks = double.Parse(Console.ReadLine());

            double price = 0.0;

            switch (drink)
            {
                case "Espresso":
                    if (sugar == "Without")
                    {
                        price = 0.90;
                    }
                    else if (sugar == "Normal")
                    {
                        price = 1.0;
                    }
                    else if (sugar == "Extra")
                    {
                        price = 1.2;
                    }
                    break;
                case "Cappuccino":
                    if (sugar == "Without")
                    {
                        price = 1.0;
                    }
                    else if (sugar == "Normal")
                    {
                        price = 1.2;
                    }
                    else if (sugar == "Extra")
                    {
                        price = 1.6;
                    }
                    break;
                case "Tea":
                    if (sugar == "Without")
                    {
                        price = 0.50;
                    }
                    else if (sugar == "Normal")
                    {
                        price = 0.6;
                    }
                    else if (sugar == "Extra")
                    {
                        price = 0.7;
                    }
                    break;
            }

          
            double endPrice = numberOfDrinks * price;

            if (sugar == "Without")
            {
                endPrice = endPrice * 0.65;
            }

            if (drink == "Espresso" && numberOfDrinks >= 5)
            {
                endPrice = endPrice * 0.75;
            }

            if (numberOfDrinks * price >= 15)
            {
                endPrice = endPrice * 0.80;
            }
            
            


            Console.WriteLine($"You bought {numberOfDrinks} cups of {drink} for {endPrice:f2} lv.");

        }
    }
}
