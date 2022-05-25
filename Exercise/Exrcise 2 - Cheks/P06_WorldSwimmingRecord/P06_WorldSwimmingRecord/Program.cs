using System;

namespace P06_WorldSwimmingRecord
{
    internal class Program
    {
        static void Main()
        {
            double recordOnSec = double.Parse(Console.ReadLine()); 
            double distanceOnMeters = double.Parse(Console.ReadLine()); 
            double timeOnSecForOneMeter = double.Parse(Console.ReadLine()); 
            int resistance = 15;
            double distanceResistance = 12.5;
            double resistanceOnWaterEnd;

            double resistanceOnWater = Math.Floor (distanceOnMeters / resistance); 
            resistanceOnWaterEnd = resistanceOnWater * distanceResistance;
            double totalSec = distanceOnMeters * timeOnSecForOneMeter ; 
            double totalSecEnd = totalSec + resistanceOnWaterEnd;

            if (totalSec < recordOnSec)
            {
                Console.WriteLine(" Yes, he succeeded! The new world record is "+($"{ totalSecEnd:f2} ")+ "seconds.");
            }
            else
            {
                double difference;
                difference =  totalSecEnd - recordOnSec;
                Math.Floor(difference);
                Console.WriteLine("No, he failed! He was " + ($"{ difference:f2} ") + "seconds slower.");
            }
        }
    }
}
