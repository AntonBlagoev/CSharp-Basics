using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openBrowserTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double fineFacebook = 150.0;
            double fineInstagram = 100.0;
            double fineReddit = 50.0;

            int countFacebook = 0;
            int countIntsagram = 0;
            int countReddit = 0;

            for (int i = 0; i < openBrowserTabs; i++)
            {

                string nameOfSites = Console.ReadLine();

                switch (nameOfSites)
                {
                    case "Facebook":
                        countFacebook++;
                        break;
                    case "Instagram":
                        countIntsagram++;
                        break;
                    case "Reddit":
                        countReddit++;
                        break;
                }
            }

            double fines = fineFacebook * countFacebook + fineInstagram * countIntsagram + fineReddit * countReddit;

            if (salary <= fines)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{(salary - fines):f0}");
            }
        }
    }

}
