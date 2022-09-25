using System;

namespace _01._USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Напишете програма за конвертиране на щатски долари (USD) в български лева (BGN). 
            Използвайте фиксиран курс между долар и лев: 1 USD = 1.79549 BGN. */

            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Console.WriteLine(bgn);
        }
    }
}
