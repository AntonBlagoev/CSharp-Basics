using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {

            string destination = Console.ReadLine();


            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                double inputNum = 0.0;

                while (inputNum < minBudget)
                {
                    inputNum += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine(); ;

            }




        }
    }
}
