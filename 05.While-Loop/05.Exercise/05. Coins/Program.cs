using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double inputSum = double.Parse(Console.ReadLine());

            int lev2 = 0;
            int lev1 = 0;
            int st50 = 0;
            int st20 = 0;
            int st10 = 0;
            int st05 = 0;
            int st02 = 0;
            int st01 = 0;

            // levove
            int lev = Convert.ToInt32(Math.Floor(inputSum));

            if (lev % 2 == 0)
            {
                lev2 = lev / 2;
            }
            else
            {
                lev2 = lev / 2;
                lev1 = 1;
            }

            // stotinki
            int st = Convert.ToInt32((inputSum % 1) * 100);

            if (st > 50)
            {
                st50 = 1;
                st20 = (st - 50) / 20;
                st10 = (st - 50 - (st20 * 20)) / 10;
                st05 = (st - 50 - (st20 * 20) - (st10 * 10)) / 5;
                st02 = (st - 50 - (st20 * 20) - (st10 * 10) - (st05 * 5)) / 2;
                st01 = (st - 50 - (st20 * 20) - (st10 * 10) - (st05 * 5) - (st02 * 2)) / 1;
            }
            else
            {
                st50 = 0;
                st20 = st / 20;
                st10 = (st - (st20 * 20)) / 10;
                st05 = (st - (st20 * 20) - (st10 * 10)) / 5;
                st02 = (st - (st20 * 20) - (st10 * 10) - (st05 * 5)) / 2;
                st01 = (st - (st20 * 20) - (st10 * 10) - (st05 * 5) - (st02 * 2)) / 1;
            }

            int countCoins = lev2 + lev1 + st50 + st20 + st10 + st05 + st02 + st01;
            Console.WriteLine(countCoins);
            */


            double input = double.Parse(Console.ReadLine());
            int changeToReturn = Convert.ToInt32(input * 100);
            
            int count = 0;

            while (changeToReturn > 0)
            {
                if (changeToReturn >= 200)
                {
                    changeToReturn -= 200;
                    count++;
                }
                else if (changeToReturn >= 100)
                {
                    changeToReturn -= 100;
                    count++;
                }
                else if (changeToReturn >= 50)
                {
                    changeToReturn -= 50;
                    count++;
                }
                else if (changeToReturn >= 20)
                {
                    changeToReturn -= 20;
                    count++;
                }
                else if (changeToReturn >= 10)
                {
                    changeToReturn -= 10;
                    count++;
                }
                else if (changeToReturn >= 5)
                {
                    changeToReturn -= 5;
                    count++;
                }
                else if (changeToReturn >= 2)
                {
                    changeToReturn -= 2;
                    count++;
                }
                else if (changeToReturn >= 1)
                {
                    changeToReturn -= 1;
                    count++;
                }
                else
                {
                    changeToReturn = 0;
                }

            }

            Console.WriteLine(count);

           
        }
    }
}
