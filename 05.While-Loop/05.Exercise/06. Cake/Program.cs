using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {

            int cakeX = int.Parse(Console.ReadLine());
            int cakeY = int.Parse(Console.ReadLine());

            int cakeS = cakeX * cakeY;

            int cakeCount = 0;
            string cakeInput = "";


            while (cakeS > cakeCount)
            {
                cakeInput = Console.ReadLine();

                if (cakeInput == "STOP")
                {
                    break;
                }

                cakeCount += int.Parse(cakeInput);

            }

            if (cakeInput == "STOP")
            {
                Console.WriteLine($"{cakeS - cakeCount} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {cakeCount - cakeS} pieces more.");
            }
        }
    }
}
