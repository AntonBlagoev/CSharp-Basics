using System;

namespace Cinema_Voucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPriceOfVouchers = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();

            int countOfTickets = 0;
            int countOfOthers = 0;

            while (inputText != "End")
            {
                

                if (inputText.Length > 8)
                {
                    if (inputText[0] + inputText[1] <= totalPriceOfVouchers)
                    {
                        totalPriceOfVouchers -= inputText[0] + inputText[1];
                        countOfTickets++;
                    }
                    else
                    {
                        break;
                    }
                    
                }
                else
                {
                    if (inputText[0] <= totalPriceOfVouchers)
                    {
                        totalPriceOfVouchers -= inputText[0];
                        countOfOthers++;
                    }
                    else
                    {
                        break;
                    }
                    
                }

                inputText = Console.ReadLine();
            }
            Console.WriteLine(countOfTickets);
            Console.WriteLine(countOfOthers);
        }
    }
}
