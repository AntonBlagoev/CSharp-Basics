using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchBook = Console.ReadLine();
            string inputBook = "";
            int countBook = 0;

            while (searchBook != inputBook)
            {
                inputBook = Console.ReadLine();
                countBook++;
                
                if (inputBook == "No More Books")
                {
                    break;
                }
            }

            if (inputBook == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countBook - 1} books.");
            }

            else
            {
                Console.WriteLine($"You checked {countBook - 1} books and found it.");
            }

        }
    }
}
