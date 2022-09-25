using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int maxNumber = int.MinValue;

            while (input != "Stop")
            {
                int inputNumber = int.Parse(input);

                if (inputNumber > maxNumber)
                {
                    maxNumber = inputNumber;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);


        }
    }
}
