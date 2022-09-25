using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
           
            double totalRating = 0.0;
            int counter = 0;
            
            while (true)
            {
                double curruntRating = 0.0;
                                
                string inputText = Console.ReadLine();

                if (inputText == "Finish")
                {
                    break;
                }
                           
                for (int i = 0; i < num; i++)
                {
                    double inputRating = double.Parse(Console.ReadLine());
                    curruntRating += inputRating;
                    totalRating += inputRating;
                    
                    counter++;
                }

                Console.WriteLine($"{inputText} - {curruntRating / num:F2}.");
                
            }
            Console.WriteLine($"Student's final assessment is {totalRating / counter:F2}.");



        }
    }
}
