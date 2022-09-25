using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());
            int points = 0;


            string stageOfTournaments;
            double countW = 0.0;

            for (int i = 0; i < tournaments; i++)
            {
                stageOfTournaments = Console.ReadLine();

                switch (stageOfTournaments)
                {
                    case "W":
                        points = points + 2000;
                        countW++;
                        break;
                    case "F":
                        points = points + 1200;
                        break;
                    case "SF":
                        points = points + 720;
                        break;

                }

            }

            Console.WriteLine($"Final points: {points + initialPoints}");
            Console.WriteLine($"Average points: {(points / tournaments)}");
            Console.WriteLine($"{(countW / tournaments) * 100:f2}%");


        }
    }
}
