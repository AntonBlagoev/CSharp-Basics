using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int imputHours = int.Parse(Console.ReadLine());
            int imputMinutes = int.Parse(Console.ReadLine());
            int addHours = 0;
            int addMinutes = 15;
            int totalHours = 0;
            int totalMinutes = 0;

            if (imputMinutes >= 45)
            {
                addHours = 1;
                totalMinutes = (imputMinutes + addMinutes) - 60;
            }
            else
            {
                addHours = 0;
                totalMinutes = (imputMinutes + addMinutes);
            }

            if ((imputHours + addHours) >= 24)
            {
                totalHours = (imputHours + addHours) - 24;
            }
            else
            {
                totalHours = (imputHours + addHours);
            }

            if (totalMinutes < 10)
            {
                Console.WriteLine($"{totalHours}:0{totalMinutes}");
            }
            else
            {
                Console.WriteLine($"{totalHours}:{totalMinutes}");
            }

        }
    }
}
