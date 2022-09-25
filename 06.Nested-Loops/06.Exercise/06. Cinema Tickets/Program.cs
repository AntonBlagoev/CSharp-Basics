using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            double freePlaces = double.Parse(Console.ReadLine());
            string ticketType = "";

            double studentTicketsCount = 0.0;
            double standardTicketsCount = 0.0;
            double kidTicketsCount = 0.0;

            double totalTickets = 0.0;

            bool end = true;

            while (end)
            {
                double currentStudentTickets = 0.0;
                double currentStandardTickets = 0.0;
                double currentKidTickets = 0.0;

                for (int i = 0; i < freePlaces; i++)
                {
                    ticketType = Console.ReadLine();
                    switch (ticketType)
                    {
                        case "student":
                            currentStudentTickets++;
                            studentTicketsCount++;
                            totalTickets++;
                            break;
                        case "standard":
                            currentStandardTickets++;
                            standardTicketsCount++;
                            totalTickets++;
                            break;
                        case "kid":
                            currentKidTickets++;
                            kidTicketsCount++;
                            totalTickets++;
                            break;
                    }
                    if (ticketType == "End")
                    {
                        break;
                    }

                    if (ticketType == "Finish")
                    {
                        movieName = "Finish";
                        end = false;
                    }
                }

                double totalCurrentTickets = (currentStudentTickets + currentStandardTickets + currentKidTickets);
                Console.WriteLine($"{movieName} - {(totalCurrentTickets / freePlaces) * 100:f2}% full.");

                ticketType = "";

                movieName = Console.ReadLine();

                if (movieName == "Finish")
                {
                   end = false;
                }
                else
                {
                    freePlaces = double.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentTicketsCount / totalTickets) * 100:f2}% student tickets.");
            Console.WriteLine($"{(standardTicketsCount / totalTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(kidTicketsCount / totalTickets) * 100:f2}% kids tickets.");
            

        }
    }
}
