using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int numbersInGroups = 0;

            double groupMusala = 0.0;
            double groupMonblan = 0.0;
            double groupKilimanjaro = 0.0;
            double groupK2 = 0.0;
            double groupEverest = 0.0;

            double totalPeople = 0.0;

            for (int i = 0; i < groups; i++)
            {
                numbersInGroups = int.Parse(Console.ReadLine());
                totalPeople = totalPeople + numbersInGroups;

                if (numbersInGroups <=5)
                {
                    groupMusala = groupMusala + numbersInGroups; 
                }
                else if (numbersInGroups <= 12)
                {
                    groupMonblan = groupMonblan + numbersInGroups;
                }
                else if (numbersInGroups <= 25)
                {
                    groupKilimanjaro = groupKilimanjaro + numbersInGroups;
                }
                else if (numbersInGroups <= 40)
                {
                    groupK2 = groupK2 + numbersInGroups;
                }
                else
                {
                    groupEverest = groupEverest + numbersInGroups;
                }

            }

            Console.WriteLine($"{(groupMusala / totalPeople) * 100:f2}%");
            Console.WriteLine($"{(groupMonblan / totalPeople) * 100:f2}%");
            Console.WriteLine($"{(groupKilimanjaro / totalPeople) * 100:f2}%");
            Console.WriteLine($"{(groupK2 / totalPeople) * 100:f2}%");
            Console.WriteLine($"{(groupEverest / totalPeople) * 100:f2}%");


        }
    }
}
