using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());

            double sneakersPrice = yearTax - (yearTax * 0.40);
            double equipmentPrice = sneakersPrice - (sneakersPrice * 0.20);
            double ballPrice = equipmentPrice / 4;
            double accessoariesPrice = ballPrice / 5;

            double totalPrice = yearTax + sneakersPrice + equipmentPrice + ballPrice + accessoariesPrice;

            Console.WriteLine(totalPrice);
        }
    }
}
