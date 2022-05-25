using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceForBeer = 1.20;

            string nameFan = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int bottleBeer = int.Parse(Console.ReadLine());
            int packetChips = int.Parse(Console.ReadLine());

            double totalForBeer = bottleBeer * priceForBeer;
            double priceForOneChips = totalForBeer * 0.45;
            double totalForChips = Math.Ceiling(priceForOneChips * packetChips);
            double totalPrice = totalForBeer + totalForChips;
            if (budget > totalPrice)
            {
                double ostatuk = budget - totalPrice;
                Console.WriteLine($"{nameFan} bought a snack and has {ostatuk:f2} leva left.");
            }
            else
            {
                double ostatuk = totalPrice - budget;
                Console.WriteLine($"{nameFan} needs {ostatuk:f2} more leva!");
            }


        }
    }
}
