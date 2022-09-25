using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int preperations = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double penPrice = pens * 5.80;
            double markerPrice = markers * 7.20;
            double preperationPrice = preperations * 1.20;

            double totalPrice = penPrice + markerPrice + preperationPrice;
            double bill = totalPrice - totalPrice * (discount / 100.0);

            Console.WriteLine(bill);
        }
    }
}
