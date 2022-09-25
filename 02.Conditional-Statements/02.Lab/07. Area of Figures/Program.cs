using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double area = 0;

            if (input == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (input == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (input == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(r, 2);
            }
            else if (input == "triangle")
            {
                double c = double.Parse(Console.ReadLine());
                double hc = double.Parse(Console.ReadLine());
                area = (c * hc) / 2;
            }

            Console.WriteLine($"{area:F3}");
        }
    }
}
