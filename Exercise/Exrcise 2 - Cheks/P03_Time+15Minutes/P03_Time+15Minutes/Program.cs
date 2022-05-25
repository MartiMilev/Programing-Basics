using System;

namespace P03_Time_15Minutes
{
    internal class Program
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int TimeInfiftin = minute + 15;

            if (TimeInfiftin > 59)
            {
                hour++;
                if (hour > 23)
                {
                    hour = 0;
                }
                TimeInfiftin = TimeInfiftin - 60;
            }
            Console.WriteLine($"{hour}:{ TimeInfiftin:D2}");

        }


    }
 }

