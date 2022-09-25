using System;

namespace _09._Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string printProduct;
            
            switch (product)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    printProduct = "fruit";
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    printProduct = "vegetable";
                    break;
                default:
                    printProduct = "unknown";
                    break;
            }

            Console.WriteLine(printProduct);
        }
    }
}
