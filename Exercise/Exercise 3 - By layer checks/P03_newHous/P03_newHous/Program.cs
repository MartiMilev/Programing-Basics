using System;

namespace P03_newHous
{
    internal class Program
    {
        static void Main()
        {
            string flower = Console.ReadLine();
            int flowerVolume = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double singlePrice;
            double totalToPay=0;
            double residue = 0;
            switch (flower)
            {
                case "Roses":
                    singlePrice = 5.00;
                    totalToPay = flowerVolume * singlePrice;

                    if (flowerVolume > 80)
                    {
                        totalToPay *= 0.9;
                    }
                    break;

                case "Dahlias":
                    singlePrice = 3.80;
                    totalToPay = flowerVolume * singlePrice;

                    if (flowerVolume > 90)
                    {
                        totalToPay *= 0.85;
                    }
                    break;

                case "Tulips":
                    singlePrice = 2.80;
                    totalToPay = flowerVolume * singlePrice;

                    if (flowerVolume > 80)
                    {
                        totalToPay *= 0.85;
                    }
                    break;

                case "Narcissus":
                    singlePrice = 3.00;
                    totalToPay = flowerVolume * singlePrice;

                    if (flowerVolume < 120)
                    {
                        totalToPay *= 1.15;
                    }
                    break;

                case "Gladiolus":
                    singlePrice = 2.50;
                    totalToPay = flowerVolume * singlePrice;

                    if (flowerVolume < 80)
                    {
                        totalToPay *= 1.20;
                    }
                    break;
            }

            if (totalToPay <= budget)
            {
                residue = budget - totalToPay;
                Console.WriteLine($"Hey, you have a great garden with {flowerVolume} {flower} and {residue:F2} leva left.");

            }
            else
            {
                residue = totalToPay - budget;
                Console.WriteLine($"Not enough money, you need {(residue):F2} leva more.");
            }
        }
    }
}
