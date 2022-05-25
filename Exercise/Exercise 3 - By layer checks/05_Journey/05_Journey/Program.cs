using System;

namespace _05_Journey
{
    internal class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double totalToPay=0;
            string rest = null;
            string where = null;

            switch (season)
            {
                case "summer":
                        if (budget <= 100)
                    {
                        totalToPay = budget * 0.3;
                    }
                        else if (budget <= 1000)
                    {
                        totalToPay = budget * 0.4;
                    }
                        else if (budget > 1000)
                    {
                        totalToPay = budget * 0.9;
                    }

                    break;

                case "winter":
                    if (budget <= 100)
                    {
                        totalToPay = budget * 0.7;
                    }
                    else if ( budget <= 1000)
                    {
                        totalToPay = budget * 0.8;
                    }
                    else if (budget > 1000)
                    {
                        totalToPay = budget * 0.9;
                    }
                    break;

            }
            if (budget <= 100)
            {
                where = "Bulgaria";
            }
            else if ( budget <=1000)
            {
                where = "Balkans";
            }
            else if (budget > 1000)
            {
                where = "Europe";
            }
            


            if (season == "summer" && budget <= 1000)
            {
                rest = "Camp";
            }
            else if (season =="winter")
            {
                rest = "Hotel";
            }
            if (season == "summer" && budget > 1000 )
            {
                rest = "Hotel";
            }
            if (season == "winter" && budget > 1000)
            {
                rest = "Hotel";
            }

            Console.WriteLine("Somewhere in " + where);
            Console.WriteLine(rest + " - " + $"{totalToPay:f2}");

        }
    }
}
