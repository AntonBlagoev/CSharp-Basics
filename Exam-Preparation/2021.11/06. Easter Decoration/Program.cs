using System;

namespace _06._Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clientNumber = int.Parse(Console.ReadLine());

            double basketPrice = 1.50;
            double wreathPrice = 3.80;
            double chocolateBunnyPrice = 7.0;

            int countPurchases = 0;
            double priceForEachClient = 0.0;
            double priceForAllClients = 0.0;

            for (int i = 0; i < clientNumber; i++)
            {
                string inputText = Console.ReadLine();

                while (inputText != "Finish")
                {
                    if (inputText == "basket")
                    {
                        priceForEachClient += basketPrice;
                    }
                    else if (inputText == "wreath")
                    {
                        priceForEachClient += wreathPrice;
                    }
                    else if (inputText == "chocolate bunny")
                    {
                        priceForEachClient += chocolateBunnyPrice;
                    }

                    countPurchases++;
                    
                    inputText = Console.ReadLine();

                    if (inputText == "Finish" && countPurchases % 2 == 0)
                    {
                        priceForEachClient = priceForEachClient * 0.80;
                    }
                }

                Console.WriteLine($"You purchased {countPurchases} items for {priceForEachClient:f2} leva.");

                priceForAllClients += priceForEachClient;
                priceForEachClient = 0.0;
                countPurchases = 0;
                
            }

            Console.WriteLine($"Average bill per client is: {priceForAllClients / clientNumber:f2} leva.");

        }
    }
}
