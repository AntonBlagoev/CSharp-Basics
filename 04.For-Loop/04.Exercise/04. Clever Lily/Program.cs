using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int evenAges = 0;
            int oddAges = 0;
            double savedMoney = 0.0;

            for (int i = 1; i <= ages; i++)
            {
                if (i % 2 == 0)
                {
                    evenAges++;
                    savedMoney = savedMoney + 10 * evenAges;
                }

                else
                {
                    oddAges++;
                }
            }

            savedMoney = savedMoney - evenAges;
            double toySavedMoney = toyPrice * oddAges;

            double diff = (savedMoney + toySavedMoney) - washingMachinePrice;


            if (diff >= 0)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }

            else
            {
                Console.WriteLine($"No! {Math.Abs(diff):f2}");
            }



        }
    }
}
