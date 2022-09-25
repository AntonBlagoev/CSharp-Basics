using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double realMoney = double.Parse(Console.ReadLine());

            string inputText = "";          //Вид действие – текст с възможности "spend" и "save"
            double inputMoney = 0.0;

            int spendCount = 0;
            int daysCount = 0;

            bool spend = false;

            while (neededMoney > realMoney)
            {
                inputText = Console.ReadLine();
                inputMoney = double.Parse(Console.ReadLine());
                
                daysCount++;

                if (inputText == "spend")
                {
                    if (inputMoney > realMoney)
                    {
                        realMoney = 0;
                    }
                    else
                    {
                        realMoney -= inputMoney;
                    }
                    
                    spendCount++;
                }
                else
                {
                    realMoney += inputMoney;
                    spendCount = 0;
                }

                if (spendCount >= 5)
                {
                    spend = true;
                    break;
                }
            }

            if (spend)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysCount}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }


        }
    }
}
