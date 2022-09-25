using System;

namespace _04._Estern_Egsg
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsNumber = int.Parse(Console.ReadLine());

            int redCount = 0;
            int orangeCount = 0;
            int blueCount = 0;
            int greenCount = 0;

            string maxColor = "";
            int maxEggCount = 0;



            for (int i = 0; i < eggsNumber; i++)
            {
                string colorOfEgg = Console.ReadLine();
                
                switch (colorOfEgg)
                {
                    case "red":
                        redCount++;
                        break;
                    case "orange":
                        orangeCount++;
                        break;
                    case "blue":
                        blueCount++;
                        break;
                    case "green":
                        greenCount++;
                        break;
                }
            }

            if (redCount >= orangeCount && redCount >= blueCount && redCount >= greenCount)
            {
                maxColor = "red";
                maxEggCount = redCount;
            }
            else if (orangeCount >= redCount && orangeCount >= blueCount && orangeCount >= greenCount)
            {
                maxColor = "orange";
                maxEggCount = orangeCount;
            }
            else if (blueCount >= redCount && blueCount >= orangeCount && blueCount >= greenCount)
            {
                maxColor = "blue";
                maxEggCount = blueCount;
            }
            else if (greenCount >= redCount && greenCount >= orangeCount && greenCount >= blueCount)
            {
                maxColor = "green";
                maxEggCount = greenCount;
            }


            Console.WriteLine($"Red eggs: {redCount}");
            Console.WriteLine($"Orange eggs: {orangeCount}");
            Console.WriteLine($"Blue eggs: {blueCount}");
            Console.WriteLine($"Green eggs: {greenCount}");
            Console.WriteLine($"Max eggs: {maxEggCount} -> {maxColor}");

        }
    }
}
