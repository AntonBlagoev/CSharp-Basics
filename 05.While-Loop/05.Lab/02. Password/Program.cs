using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string passwordCheck = Console.ReadLine();

            while (passwordCheck != password)
            {
                passwordCheck = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");


        }
    }
}
