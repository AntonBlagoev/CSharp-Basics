using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativeGradesMaxNumber = int.Parse(Console.ReadLine());

            int negativeGradeCounter = 0;
            string taskName = "";
            int inputGrade = 0;
            int inputGradeCounter = 0;
            double sumGrades = 0.0;

            while (true)
            {
                string inputTaskName = Console.ReadLine();
                if (inputTaskName == "Enough")
                {
                    Console.WriteLine($"Average score: {sumGrades / inputGradeCounter:f2}");
                    Console.WriteLine($"Number of problems: {inputGradeCounter}");
                    Console.WriteLine($"Last problem: {taskName}");
                    break;
                }

                inputGrade = int.Parse(Console.ReadLine());
                sumGrades += inputGrade;
                inputGradeCounter++;

                

                taskName = inputTaskName;

                if (inputGrade <= 4)
                {
                    negativeGradeCounter++;
                }

                if (negativeGradesMaxNumber <= negativeGradeCounter)
                {
                    Console.WriteLine($"You need a break, {negativeGradeCounter} poor grades.");
                    break;
                }


            }

            



        }
    }
}
