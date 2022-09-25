using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowersNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double flowersPrice = 0.0;
            double discount = 1.0;

            switch (flowersType)
            {
                case "Roses":
                    flowersPrice = 5.00;
                        if (flowersNumber > 80)
                        {
                            discount = 0.90;
                        }
                    break;
                case "Dahlias":
                    flowersPrice = 3.80;
                    if (flowersNumber > 90)
                    {
                        discount = 0.85;
                    }
                    break;
                case "Tulips":
                    flowersPrice = 2.80;
                    if (flowersNumber > 80)
                    {
                        discount = 0.85;
                    }
                    break;
                case "Narcissus":
                    flowersPrice = 3.00;
                    if (flowersNumber < 120)
                    {
                        discount = 1.15;
                    }
                    break;
                case "Gladiolus":
                    flowersPrice = 2.50;
                    if (flowersNumber < 80)
                    {
                        discount = 1.20;
                    }
                    break;


                default:
                    break;
            }


            double totalPrice = (flowersNumber * flowersPrice) * discount;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersNumber} {flowersType} and {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");

            }
        }
    }
}
