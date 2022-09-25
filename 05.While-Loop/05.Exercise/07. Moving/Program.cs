using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {

            int boxX = int.Parse(Console.ReadLine());
            int boxY = int.Parse(Console.ReadLine());
            int boxZ = int.Parse(Console.ReadLine());

            int boxS = boxX * boxY * boxZ;

            int boxCount = 0;
            string boxInput = "";

            while (boxS > boxCount)
            {
                boxInput = Console.ReadLine();

                if (boxInput == "Done")
                {
                    break;
                }
                boxCount += int.Parse(boxInput);
            }

            if (boxInput == "Done")
            {
                Console.WriteLine($"{boxS - boxCount} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {boxCount - boxS} Cubic meters more.");
            }





        }
    }
}
