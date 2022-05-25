using System;

namespace P08_LunchBreak
{
    internal class Program
    {
        static void Main()
        {
            string nameOfSerial = (Console.ReadLine());
            int timingEp = int.Parse(Console.ReadLine());
            double timeForChill = int.Parse(Console.ReadLine());

            double timeForLunch = timeForChill /  8;
            double timeForRest = timeForChill / 4;
            double allTime =timeForChill - timeForLunch - timeForRest;
            double reside = allTime - timingEp;
            Math.Ceiling(reside);

            if (allTime >= timingEp)
            {
                Console.WriteLine("You have enough time to watch " 
                + nameOfSerial + " and left with " + Math.Ceiling(reside) + " minutes free time. ");
            }
            else
            {
                reside = timingEp - allTime;
                Console.WriteLine("You don't have enough time to watch "+ nameOfSerial+
                    ", you need "+ Math.Ceiling(reside) +" more minutes.");
            }
        }
    }
}
