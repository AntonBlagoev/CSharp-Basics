using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumLeft = 0;
            int sumRight = 0;
            

            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                sumLeft = sumLeft + inputNumber;
            }

            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                sumRight = sumRight + inputNumber;
            }
            
            int diff = Math.Abs(sumLeft - sumRight);

            if (diff == 0)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");
            }
            else
            {
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
