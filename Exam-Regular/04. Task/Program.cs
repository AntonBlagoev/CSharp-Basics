using System;

namespace _04._Task
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double averageRating = 0;
            double realSales = 0.0;

            for (int i = 0; i < n; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                
                double ratingNum = inputNum % 10;
                averageRating += ratingNum;
                double rating = 0.0;

                switch (ratingNum)
                {
                    case 2:
                        rating = 0.0;
                        break;
                    case 3:
                        rating = 0.50;
                        break;
                    case 4:
                        rating = 0.70;
                        break;
                    case 5:
                        rating = 0.85; // 85% от възможните продажби
                        break;
                    case 6:
                        rating = 1.0; // 100% от възможните продажби
                        break;
                }

                double possibleSales = inputNum / 10;
                realSales += possibleSales * rating;

            }

            Console.WriteLine($"{realSales:f2}");
            Console.WriteLine($"{averageRating / n:f2}");


        }
    }
}
