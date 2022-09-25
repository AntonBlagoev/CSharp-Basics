using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {
                    count++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNum})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{count} combinations - neither equals {magicNum}");

        }
    }
}
