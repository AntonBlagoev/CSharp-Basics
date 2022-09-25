using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {

            string movieName = Console.ReadLine();
            
            string ticketType = "";
            double totalTickets = 0;
            int currеntCount = 0;

            double studentTickets = 0;
            double standardTickets = 0;
            double kidTickets = 0;


            while (movieName != "Finish")
            {
                double freePlaces = double.Parse(Console.ReadLine());
                

                for (int i = 0; i < freePlaces; i++)
                {
                    ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }
                    else if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTickets++;
                    }

                    currеntCount++;
                    totalTickets++;
                  
                }


                Console.WriteLine($"{movieName} - {(currеntCount / freePlaces) * 100:f2}% full.");
                currеntCount = 0;
                movieName = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentTickets / totalTickets) * 100:f2}% student tickets.");
            Console.WriteLine($"{(standardTickets / totalTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(kidTickets / totalTickets) * 100:f2}% kids tickets.");



        }
    }
}
