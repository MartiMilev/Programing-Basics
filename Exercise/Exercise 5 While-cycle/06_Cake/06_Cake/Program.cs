using System;

namespace _06_Cake
{
    internal class Program
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int cakeVolume = lenght * width;
            bool stopEating = false;
            int pieacOfCake=0;
            bool cakeEnd = false;

            while(true)
            {
            string cakeDone = Console.ReadLine();
                if (cakeDone =="STOP")
                {
                    stopEating = true;
                    break;
                }
                pieacOfCake = int.Parse(cakeDone);
                cakeVolume -= pieacOfCake;
                if (cakeVolume <= 0)
                {
                    cakeEnd = true;
                    break;
                }
            }
            if (stopEating)
            {
                Console.WriteLine($"{cakeVolume} pieces are left.");
            }
            if (cakeEnd)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeVolume)} pieces more.");
            }
        }
    }
}
