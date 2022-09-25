using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int minNumber = int.MaxValue;

            while (input != "Stop")
            {
                int inputNumber = int.Parse(input);

                if (inputNumber < minNumber)
                {
                    minNumber = inputNumber;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
