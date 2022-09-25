using System;

namespace _04._Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            /* v.1
            if (age >= 16 && gender == "m")
            {
                Console.WriteLine("Mr.");
            }
            else if (age < 16 && gender == "m")
            {
                Console.WriteLine("Master");
            }
            else if (age >= 16 && gender == "f")
            {
                Console.WriteLine("Ms.");
            }
            else
            {
                Console.WriteLine("M");
            }
            */
            //v.2

            if (age >= 16)
            {
                if (gender == "m")
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
            else
            {
                if (gender == "m")
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }




        }
    }
}
