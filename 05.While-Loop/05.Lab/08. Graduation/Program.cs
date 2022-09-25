using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();

            double yearGrade = 0.0;
            double inputGrade = 6.0;
            int countYears = 0;

            while (inputGrade >= 4  && countYears < 12)
            {
                inputGrade = double.Parse(Console.ReadLine());
                yearGrade += inputGrade;
                countYears++;
            }

            if (countYears < 12)
            {
                Console.WriteLine($"{name} has been excluded at {countYears} grade");
            }

            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {yearGrade / countYears:f2}");
            }
    
            
        }
    }
}
