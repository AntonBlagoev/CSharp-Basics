using System;

namespace Movie_rating
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieNumbers = double.Parse(Console.ReadLine());

            string movieName;
            double inputRating;

            string highestRatingMovie = "";
            string lowestRatingMovie = "";
           
            double highestRating = int.MinValue;
            double lowestRating = int.MaxValue;
            double averageRating = 0.0;
            

            for (int i = 0; i < movieNumbers; i++)
            {
                movieName = Console.ReadLine();
                inputRating = double.Parse(Console.ReadLine());
                averageRating += inputRating;

                if (inputRating >= highestRating)
                {
                    highestRating = inputRating;
                    highestRatingMovie = movieName;
                }
                else if (inputRating <= lowestRating)
                {
                    lowestRating = inputRating;
                    lowestRatingMovie = movieName;
                }
               

            }



            Console.WriteLine($"{highestRatingMovie} is with highest rating: {highestRating:f1}");
            Console.WriteLine($"{lowestRatingMovie} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {averageRating / movieNumbers:f1}");


        }
    }
}
