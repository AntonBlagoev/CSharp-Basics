using System;

namespace _02._Family_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());           //•	Бюджетът
            int nightsNumber = int.Parse(Console.ReadLine());           //•	Брой нощувки 
            double nightsPrice = double.Parse(Console.ReadLine());      //•	Цена за нощувка 
            double costsAdd = int.Parse(Console.ReadLine());               //•	Процент за допълнителни разходи

            double discount = 1.0;            

            if (nightsNumber > 7)        //ако броят на нощувките е по-голям от 7, цената за нощувка се намаля с 5%
            {
                discount = 0.95;
            }

            double nightsTotalPrice = (nightsNumber * (nightsPrice * discount)) + (budget * (costsAdd / 100));


            if (budget >= nightsTotalPrice)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - nightsTotalPrice:f2} leva after vacation.");
            }

            else
            {
                Console.WriteLine($"{nightsTotalPrice - budget:f2} leva needed");
            }


        }
    }
}
