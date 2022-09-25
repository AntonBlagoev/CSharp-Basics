using System;

namespace _01._Task
{
    class Program
    {
        static void Main(string[] args)
        {
            double fat = double.Parse(Console.ReadLine());
            double prot = double.Parse(Console.ReadLine());
            double carbo = double.Parse(Console.ReadLine());
            double calories = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());

            
            double fatGram = ((fat / 100) * calories) / 9;
            double protGram = ((prot / 100) * calories) / 4;
            double carboGram = ((carbo / 100) * calories) / 4;

            double caloriesGram = calories / (fatGram + protGram + carboGram);

            double totalCalories = caloriesGram - (caloriesGram * (water / 100));

            Console.WriteLine($"{totalCalories:f4}");
        }
    }
}
