using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nylonPrice = ((nylon + 2) * 1.50) + 0.40;
            double paintPrice = (paint * 1.1) * 14.50;
            double thinnerPrice = thinner * 5.00;
            double mastersPrice = hours * ((nylonPrice + paintPrice + thinnerPrice) * 0.30);

            double costs = nylonPrice + paintPrice + thinnerPrice + mastersPrice;

            Console.WriteLine(costs);
        }
    }
}
