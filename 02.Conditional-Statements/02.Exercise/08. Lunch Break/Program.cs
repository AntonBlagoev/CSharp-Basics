using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            double movieDuration = double.Parse(Console.ReadLine());
            double breakDuration = double.Parse(Console.ReadLine());
            double lunchTime = breakDuration / 8;
            double restTime = breakDuration / 4;
            double timeForMovie = breakDuration - lunchTime - restTime;

            if (timeForMovie >= movieDuration)
            {
                Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(timeForMovie - movieDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(movieDuration - timeForMovie)} more minutes.");
            }
        }
    }
}
