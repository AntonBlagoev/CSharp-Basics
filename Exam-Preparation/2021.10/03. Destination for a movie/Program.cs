using System;

namespace _03._Destination_for_a_movie
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string seasson = Console.ReadLine();
            int days =int.Parse(Console.ReadLine());

            double priceForDay = 0.0;
            double discount = 1.0;

            if (seasson == "Winter")
            {
                switch (destination)
                {
                    case "Dubai":
                        priceForDay = 45000.00;
                        discount = 0.7;             //•	Ако дестинацията е Дубай – 30% отстъпка от крайната цена
                        break;
                    case "Sofia":
                        priceForDay = 17000.00;
                        discount = 1.25;             //•	Ако дестинацията е София – цената се оскъпява с 25%
                        break;
                    case "London":
                        priceForDay = 24000.00;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (destination)
                {
                    case "Dubai":
                        priceForDay = 40000.00;
                        discount = 0.7;             //•	Ако дестинацията е Дубай – 30% отстъпка от крайната цена
                        break;
                    case "Sofia":
                        priceForDay = 12500.00;
                        discount = 1.25;             //•	Ако дестинацията е София – цената се оскъпява с 25%
                        break;
                    case "London":
                        priceForDay = 20250.00;
                        break;
                    default:
                        break;
                }
            }

            double costs = days * priceForDay * discount;

            if (budget >= costs)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget - costs:f2} leva left!");
            }

            else
            {
                Console.WriteLine($"The director needs {costs - budget:f2} leva more!");
            }

        }
    }
}
