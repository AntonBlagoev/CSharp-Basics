using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());

            double chickenPrice = chicken * 10.35;
            double fishPrice = fish * 12.40;
            double veganPrice = vegan * 8.15;
            double foodPrice = chickenPrice + fishPrice + veganPrice;
            double desertPrice = foodPrice * 0.20;
            double deliveryPrice = 2.50;

            double totalPrice = foodPrice + desertPrice + deliveryPrice;

            Console.WriteLine(totalPrice);
        }
    }
}
