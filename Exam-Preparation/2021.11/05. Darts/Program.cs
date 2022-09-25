using System;

namespace _05._Darts
{
    class Program
    {
        static void Main(string[] args)
        {

            string playerName = Console.ReadLine();
            string inputText = Console.ReadLine();

            int totalPoints = 301;
            int countSuccessfulShots = 0;
            int countUnsuccessfulShots = 0;

            bool winner = false;

            while (inputText != "Retire")
            {
                int inputPoints = int.Parse(Console.ReadLine());

                if (inputText == "Single")
                {
                    inputPoints = inputPoints * 1;
                }
                else if (inputText == "Double")
                {
                    inputPoints = inputPoints * 2;
                }
                else if (inputText == "Triple")
                {
                    inputPoints = inputPoints * 3;
                }

                if (totalPoints - inputPoints < 0)
                {
                    countUnsuccessfulShots++;
                    inputText = Console.ReadLine();
                    continue;
                }
                else if (totalPoints - inputPoints == 0)
                {
                    winner = true;
                    countSuccessfulShots++;
                    break;
                }

            
                
                countSuccessfulShots++;

                totalPoints -= inputPoints;

                inputText = Console.ReadLine();
            }

            if (winner)
            {
                Console.WriteLine($"{playerName} won the leg with {countSuccessfulShots} shots.");
            }

            else
            {
                Console.WriteLine($"{playerName} retired after {countUnsuccessfulShots} unsuccessful shots.");
            }


        }
    }
}
