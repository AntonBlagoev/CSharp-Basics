using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                string numToText = i.ToString();
                
                int counter = 0;

                for (int j = 0; j < 4; j++)
                {
                   int curruntNumber = int.Parse(numToText[j].ToString()); // = Convert.ToInt32(numberToText[j].ToString());

                    if (curruntNumber != 0 && num % curruntNumber == 0)
                    {
                        counter++;
                        
                    }
                    else
                    {
                        counter = 0;
                        break;
                    }

                }

                if (counter == 4)
                {
                    Console.Write($"{i} ");
                }

                

               
            }

        }
    }
}
