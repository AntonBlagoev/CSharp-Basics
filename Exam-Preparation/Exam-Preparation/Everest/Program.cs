using System;

namespace Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            
            int meters = 5634 + int.Parse(Console.ReadLine());

            int daysCounter = 0;

            bool winn = false;

            while (inputText != "END")
            {
                if (inputText == "Yes")
                {
                    daysCounter++;
                }

                if (meters >= 8448)
                {
                    winn = true;
                    break;
                }

                if (daysCounter >= 5)
                {
                    break;
                }

                inputText = Console.ReadLine();
                if (inputText == "END")
                {
                    break;
                }
                meters += int.Parse(Console.ReadLine());
            }

            if (winn)
            {
                Console.WriteLine($"Goal reached for {daysCounter} days!");
            }
            else
            {
                Console.WriteLine($"Failed! {meters}");
            }
        }
    }
}
