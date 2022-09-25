using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            int timeOfExam = hourOfExam * 60 + minuteOfExam;
            int timeOfArrival = hourOfArrival * 60 + minuteOfArrival;

            int timeResult = timeOfExam - timeOfArrival;
            int hourResult = Math.Abs(timeResult / 60);
            int minuteResult = Math.Abs(timeResult % 60);

                        
            if (timeResult < 0)
            {
                Console.WriteLine("Late");
                if (timeResult <= -60)
                {
                    Console.WriteLine($"{hourResult}:{minuteResult.ToString("00")} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{minuteResult} minutes after the start");
                }
            }
            else if (timeResult >=0 && timeResult <=30)
            {
                

                if (timeResult == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minuteResult} minutes before the start");
                }
            }
            else if (timeResult > 30)
            {
                Console.WriteLine("Early");

                if (timeResult >= 60)
                {
                    Console.WriteLine($"{hourResult}:{minuteResult.ToString("00")} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{minuteResult} minutes before the start");
                }

            }
           
        }
    }
}
