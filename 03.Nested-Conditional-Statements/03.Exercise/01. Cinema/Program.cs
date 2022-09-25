using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double numberOfChairs = r * c;
            double ticketPrice = 0.0;

            switch (projectionType)
            {
                case "Premiere":
                    ticketPrice = 12.00;
                    break;
                case "Normal":
                    ticketPrice = 7.50;
                    break;
                case "Discount":
                    ticketPrice = 5.00;
                    break;
                default:
                    break;
            }

            double ticketRevenue = numberOfChairs * ticketPrice;

            Console.WriteLine($"{ticketRevenue:F2} leva");


        }
    }
}
