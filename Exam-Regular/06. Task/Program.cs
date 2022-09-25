using System;

namespace _06._Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool notFound = false;
            

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 9; b >= a; b--)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 9; d >= c; d--)
                        {
                            if ((a + b + c + d) == (a * b * c * d) && n % 10 == 5)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                return;
                            }
                           
                            if ((a * b * c * d) / (a + b + c + d) == 3 && n % 3 == 0)
                            {
                                Console.Write($"{d}{c}{b}{a} ");
                                return;
                            }
                            else
                            {
                                notFound = true;
                            }
                        }
                    }
                }
            }

            if (notFound)
            {
                Console.WriteLine("Nothing found");
            }




        }
    }
}
