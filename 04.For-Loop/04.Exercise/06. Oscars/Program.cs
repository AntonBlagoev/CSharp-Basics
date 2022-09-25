using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int numbersOfEvaluators = int.Parse(Console.ReadLine());


            for (int i = 0; (i < numbersOfEvaluators) && (points <= 1250.5); i++)
            {
                string evaluatorName = Console.ReadLine();
                double pointsOfEvaluator = double.Parse(Console.ReadLine());
                points = points + (((evaluatorName.Length) * pointsOfEvaluator) / 2);

                
            }

            if (points > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:F1}!");
            }

            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - (points):F1} more!");
            }

        }
    }
}
