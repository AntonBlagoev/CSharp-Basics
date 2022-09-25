using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 1; i <= n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven = sumEven + inputNumber;
                }
                else
                {
                    sumOdd = sumOdd + inputNumber;
                }
            }

            int diff = Math.Abs(sumEven - sumOdd);

            if (diff == 0)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sumEven}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
