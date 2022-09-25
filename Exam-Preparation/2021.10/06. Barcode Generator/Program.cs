using System;

namespace _06._Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

           
            for (int d1 = num1 / 1000; d1 <= num2 / 1000; d1++)
            {
                if (d1 % 2 == 0)
                {
                    continue;
                }
                for (int d2 = num1 /100 % 10; d2 <= num2 / 100 % 10; d2++)
                {
                    if (d2 % 2 == 0)
                    {
                        continue;
                    }
                    for (int d3 = num1 / 10 % 10; d3 <= num2 / 10 % 10; d3++)
                    {
                        if (d3 % 2 == 0)
                        {
                            continue;
                        }
                        for (int d4 = num1 % 10; d4 <= num2 % 10; d4++)
                        {
                            if (d4 % 2 == 0)
                            {
                                continue;
                            }
                            Console.Write($"{d1}{d2}{d3}{d4} ");
                        }
                    }
                }



            }

        }
    }
}
