using System;

namespace _04_Fishing_Boat
{
    internal class Program
    {
        static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishurs = int.Parse(Console.ReadLine());

            int priceForSpring ;
            int priceForSummer ;
            int priceForWinter ;
            int priceForAutumn;
            double totalToPay=0;
            double ostatuk;

            switch (season)
            {
                case "Spring":
                    priceForSpring = 3000;
                    if (fishurs <=6)
                    {
                        totalToPay = priceForSpring * 0.9;
                    }
                    else if (fishurs >= 7 && fishurs <= 11)
                    {
                        totalToPay = priceForSpring * 0.85;
                    }
                    else if (fishurs >= 12 )
                    {
                        totalToPay = priceForSpring * 0.75;
                    }
                    
                    break;

                case "Summer":
                    priceForSummer = 4200;
                    if (fishurs <=6)
                    {
                        totalToPay = priceForSummer * 0.9;
                    }
                    else if (fishurs >=7 && fishurs <=11)
                    {
                        totalToPay = priceForSummer * 0.85;
                    }
                    else if (fishurs >= 12)
                    {
                        totalToPay = priceForSummer * 0.75;
                    }
                    
                    break;
                case "Autumn":
                    priceForAutumn = 4200;
                    if (fishurs <=6)
                    {
                        totalToPay = priceForAutumn * 0.9;
                    }
                    else if (fishurs >= 7 && fishurs <= 11)
                    {
                        totalToPay = priceForAutumn * 0.85;
                    }
                    else if (fishurs >= 12)
                    {
                        totalToPay = priceForAutumn * 0.75;
                    }
                    break;

                case "Winter":
                    priceForWinter = 2600;
                    if (fishurs <=6)
                    {
                        totalToPay = priceForWinter * 0.9;
                    }
                    else if (fishurs >= 7 && fishurs <= 11)
                    {
                        totalToPay = priceForWinter * 0.85;
                    }
                    else if (fishurs >= 12)
                    {
                        totalToPay = priceForWinter * 0.75;
                    }
                    
                    break;
            }
            if (season != "Autumn")
            {
                if (fishurs % 2 ==0)
                {
                    totalToPay *= 0.95;
                }
            }
                if (budget >= totalToPay)
                {
                    ostatuk = budget - totalToPay;
                    Console.WriteLine("Yes! You have " + $"{ ostatuk:f2}" + " leva left.");
                }
                else
                {
                    ostatuk = totalToPay - budget;
                    Console.WriteLine("Not enough money! You need " + $"{ostatuk:f2}" + " leva.");
                }
        }
    }
}
