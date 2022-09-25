using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetPrice = double.Parse(Console.ReadLine());
            int extraNumbers = int.Parse(Console.ReadLine());
            double extraClothingPrice = double.Parse(Console.ReadLine());

            double decorPrice = budgetPrice * 0.10;      //Декорът за филма е на стойност 10% от бюджета
            double discount = 0.10;                      //При повече от 150 статиста,  има отстъпка за облеклото на стойност 10%
            double clothingPrice;
            double costs;

            if (extraNumbers > 150)
            {
                clothingPrice = (extraNumbers * extraClothingPrice) - ((extraNumbers * extraClothingPrice) * discount);
            }
            else
            {
                clothingPrice = (extraNumbers * extraClothingPrice);
            }
            
            costs = decorPrice + clothingPrice;

            if (budgetPrice >= costs)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budgetPrice - costs:F2} leva left.");

            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {costs - budgetPrice:F2} leva more.");
            }


        }
    }
}
