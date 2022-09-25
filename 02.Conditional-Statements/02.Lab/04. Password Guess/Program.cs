using System;

namespace _04._Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string pasword = Console.ReadLine();

            if (pasword == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
