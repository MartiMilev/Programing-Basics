using System;

namespace P09_FishTank
{
    internal class Program
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double purcent = double.Parse(Console.ReadLine());
            double accessories;
            double Volume;
            Volume = (length * width * height)/1000;
            double OccupiedSpace;
            OccupiedSpace = purcent / 100;
            double TotalVolume = Volume *(1 - OccupiedSpace);
            Console.WriteLine(TotalVolume);



        }
    }
}
