using System;

namespace Exam_Prperation
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalPriceOfVouchers = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();
            
            double priceOfVoucher = 0.0;
            int countOfTickets = 0;
            int countOfOthers = 0;

            while (inputText != "End")
            {
                if (priceOfVoucher >= totalPriceOfVouchers)
                {
                    break;
                }
                if (inputText.Length > 8)
                {
                    priceOfVoucher += inputText[0] + inputText[1];
                    if (priceOfVoucher >= totalPriceOfVouchers)
                    {
                        break;
                    }
                    countOfTickets++;
                }
                else if(inputText.Length > 0)
                {
                    
                    priceOfVoucher += inputText[0];
                    if (priceOfVoucher >= totalPriceOfVouchers)
                    {
                        break;
                    }
                    countOfOthers++;
                }
                else
                {
                    break;
                }
               

                inputText = Console.ReadLine();

            }

            Console.WriteLine(countOfTickets);
            Console.WriteLine(countOfOthers);


        }
    }
}
