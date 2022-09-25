using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= num; i ++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    Console.Write($"{count} ");

                    if (count >= num)
                    {
                        return;
                    }

                    
                }
                Console.WriteLine();

            }


        }
    }
}
