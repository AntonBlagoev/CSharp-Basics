using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double totalVolume = (lenght * width * hight) * 0.001;
            double busyVolume = totalVolume * (percent / 100.0);
            double emptyVolume = totalVolume - busyVolume;
            Console.WriteLine(busyVolume);
        }
    }
}
