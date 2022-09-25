using System;

namespace _02._Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus = 0;
            int evenBonus = 0;
            int numberBonus = 0;

            // Основни бонуси
            if (number <= 100)           //Ако числото е до 100 включително, бонус точките са 5
            {
                bonus = 5;
            }
            else if (number <= 1000)    //Ако числото е по-голямо от 100, бонус точките са 20% от числото.
            {
                bonus = number * 0.2; 
            }
            else if (number > 1000)     //Ако числото е по-голямо от 1000, бонус точките са 10% от числото
            {
                bonus = number * 0.1;
            }

            // Допълнителни бонуси

            if (number % 2 == 0)        //За четно число -> +1 т.
            {
                evenBonus = 1;
            }

            else if (number % 10 == 5)  //За число, което завършва на 5 -> +2 т.
            {
                numberBonus = 2;
            }

            double totalBonuses = bonus + evenBonus + numberBonus;
            double totalPointS = number + totalBonuses;
            

            Console.WriteLine(totalBonuses);
            Console.WriteLine(totalPointS);
        }
    }
}
