using System;

namespace _01._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());        // цена на ягодите
            double bananasQuantity = double.Parse(Console.ReadLine());          // количество на бананите
            double orangesQuantity = double.Parse(Console.ReadLine());          // количество на портокалите
            double raspberriesQuantity = double.Parse(Console.ReadLine());      // количество на малините
            double strawberriesQuantity = double.Parse(Console.ReadLine());     // количество на ягодите

            double raspberriesPrice = strawberriesPrice / 2;  // цената на малините е на половина по-ниска от тази на ягодите
            double orangePrice = raspberriesPrice * 0.6;       // цената на портокалите е с 40% по-ниска от цената на малините
            double bananasPrice = raspberriesPrice * 0.2;      // цената на бананите е с 80% по-ниска от цената на малините

            double totalPrice = (strawberriesPrice * strawberriesQuantity) + (raspberriesPrice * raspberriesQuantity) + (orangePrice * orangesQuantity) + (bananasPrice * bananasQuantity);

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
