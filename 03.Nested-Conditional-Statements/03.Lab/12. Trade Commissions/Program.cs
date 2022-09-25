using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commissions = 0.0;




            switch (city)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        commissions = 0.05;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commissions = 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commissions = 0.08;
                    }
                    else if (sales > 10000)
                    {
                        commissions = 0.12;
                    }
                    break;

                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        commissions = 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commissions = 0.075;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commissions = 0.10;
                    }
                    else if (sales > 10000)
                    {
                        commissions = 0.13;
                    }
                    break;

                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        commissions = 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commissions = 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commissions = 0.12;
                    }
                    else if (sales > 10000)
                    {
                        commissions = 0.145;
                    }
                    break;
            }
            if (commissions > 0)
            {
                Console.WriteLine($"{sales * commissions:F2}");
                
            }
            else
            {
                Console.WriteLine("error");
            }
            




        }
    }
}
