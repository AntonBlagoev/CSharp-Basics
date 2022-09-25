using System;

namespace _05._Task
{
    class Program
    {
        static void Main(string[] args)
        {

            int targetIncome = int.Parse(Console.ReadLine());

            string inputCommand = Console.ReadLine();

            int income = 0;
            bool targetReached = false;

            while (inputCommand != "closed")
            {
                string inputService = Console.ReadLine();

                if (inputCommand == "haircut")
                {
                    switch (inputService)
                    {
                        case "mens":
                            income += 15;
                            break;
                        case "ladies":
                            income += 20;
                            break;
                        case "kids":
                            income += 10;
                            break;
                    }
                }
                else if (inputCommand == "color")
                {
                    switch (inputService)
                    {
                        case "touch up":
                            income += 20;
                            break;
                        case "full color":
                            income += 30;
                            break;
                    }
                }

                if (income >= targetIncome)
                {
                    targetReached = true;
                    break;
                }

                if (inputCommand == "closed")
                {
                    break;
                }


                inputCommand = Console.ReadLine();
            }

            if (targetReached)
            {
                Console.WriteLine($"You have reached your target for the day!");
            }
            else
            {
                Console.WriteLine($"Target not reached! You need {targetIncome - income}lv. more.");
            }

            Console.WriteLine($"Earned money: {income}lv.");
        }
    }
}
