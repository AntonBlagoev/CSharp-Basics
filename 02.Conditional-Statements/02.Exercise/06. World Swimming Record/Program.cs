using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());  
            double distance = double.Parse(Console.ReadLine()); 
            double time = double.Parse(Console.ReadLine());  

            double waterResistens = Math.Floor(distance / 15) * 12.5;
            double result = (distance * time) + waterResistens;

            if (result < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {result:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(record - result):F2} seconds slower.");
            }



        }
    }
}
