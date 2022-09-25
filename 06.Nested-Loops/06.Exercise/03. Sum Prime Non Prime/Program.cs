using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeSum = 0;
            int nonPrimeSum = 0;
          
            while (input != "stop")
            {
                int inputNum = Convert.ToInt32(input);

                if (inputNum >= 0)
                {
                    if (inputNum % 2 == 0 && inputNum > 2)
                    {
                        nonPrimeSum += inputNum;
                    }
                    else if (inputNum % 3 == 0 && inputNum > 3)
                    {
                        nonPrimeSum += inputNum;
                    }
                    else
                    {
                        primeSum += inputNum;
                    }
                }
                else
                {
                    Console.WriteLine("Number is negative.");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
           
        }
    }
}
