using System;

namespace Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int d1 = 1; d1 <= num/100; d1++)
            {
                for (int d2 = 1; d2 <= num / 10 % 10; d2++)
                {

                    for (int d3 = 1; d3 <= num % 10; d3++)
                    {
                        Console.WriteLine($"{d1} * {d2} * {d3} = {d1 * d2 * d3}");
                    }

                }
            }

        }
    }
}
