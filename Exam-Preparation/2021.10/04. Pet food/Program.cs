using System;

namespace _04._Pet_food
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());

            double dogFoodTotal = 0.0;
            double catFoodTotal= 0.0;

            double dogFoodForDay = 0.0;
            double catFoodFotDay = 0.0;

            double cookiesForDay = 0.0;
            double cookiesTotal = 0.0;

            for (int i = 1; i <= days; i++)
            {
                dogFoodForDay = double.Parse(Console.ReadLine());
                catFoodFotDay = double.Parse(Console.ReadLine());

                dogFoodTotal += dogFoodForDay;
                catFoodTotal += catFoodFotDay;

                if (i % 3 == 0)
                {
                    cookiesForDay = (dogFoodForDay + catFoodFotDay) * 0.1;
                    cookiesTotal += cookiesForDay;
                }
            }

            double totalFoodEaten = dogFoodTotal + catFoodTotal;

            Console.WriteLine($"Total eaten biscuits: {cookiesTotal:f0}gr.");
            Console.WriteLine($"{((dogFoodTotal + catFoodTotal) / totalFood) * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{(dogFoodTotal / totalFoodEaten) * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{(catFoodTotal / totalFoodEaten) * 100:f2}% eaten from the cat.");



        }
    }
}
