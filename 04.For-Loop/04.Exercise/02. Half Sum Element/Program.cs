using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxValues = int.MinValue;
            int sumValues = 0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sumValues = sumValues + num;

                if (num > maxValues)
                {
                    maxValues = num;
                }
            }

            int diff = Math.Abs(maxValues - (sumValues - maxValues));

            if (diff == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxValues}");
            }

            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
            
        }
    }
}
