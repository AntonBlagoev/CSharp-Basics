using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsFood = int.Parse(Console.ReadLine());
            int catsFood = int.Parse(Console.ReadLine());
            double sum = (dogsFood * 2.50) + (catsFood * 4);

            Console.WriteLine($"{sum} lv.");
        }
    }
}
