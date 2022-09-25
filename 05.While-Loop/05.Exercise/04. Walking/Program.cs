using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {

            int steps = 0;

            while (steps < 10000)
            {
                string inputText = Console.ReadLine();

                if (inputText == "Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    break;
                }

                else
                {
                    steps += int.Parse(inputText);
                }

            }

            if (steps < 10000)
            {
                Console.WriteLine($"{10000 - steps} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{steps - 10000} steps over the goal!");
            }

        }
    }
}
