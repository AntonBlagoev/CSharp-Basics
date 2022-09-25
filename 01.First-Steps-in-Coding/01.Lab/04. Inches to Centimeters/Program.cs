using System;

namespace _04._Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double imput = double.Parse(Console.ReadLine());
            double result = imput * 2.54;

            Console.WriteLine(result);
        }
    }
}
