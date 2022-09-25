using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                string currentNum = i.ToString();
                int evenSum = 0;
                int OddSum = 0;

                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    
                    if (j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        OddSum += currentDigit;
                    }
                }

                if (evenSum == OddSum)
                {
                    Console.Write(i + " ");
                }

            } 
            
            
            
            
            
            
            /*

            while (num1 <= num2)
            {
                int sumEven = (num1 / 100000) + ((num1 % 10000) / 1000) + (num1 % 100 / 10);
                int sumOdd = ((num1 % 100000) / 10000) + ((num1 % 1000) / 100) + (num1 % 10);

                if (sumEven == sumOdd)
                {
                    Console.Write($"{num1} ");
                }
                num1++;


            }
            */

        }
    }
}
