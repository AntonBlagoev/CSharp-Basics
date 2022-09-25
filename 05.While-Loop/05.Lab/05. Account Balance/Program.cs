using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double account = 0.0;

            while (input != "NoMoreMoney")
            {

                double moneyInput = double.Parse(input);

                if (moneyInput < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                account += moneyInput;
                Console.WriteLine($"Increase: {moneyInput:f2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {account:f2}");
        }
    }
}
