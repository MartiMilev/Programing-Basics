using System;

namespace _04_CleverLily
{
    internal class Program
    {
        static void Main()
        {
            int currentAge = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double ToyPrice = double.Parse(Console.ReadLine());

            int toysNum = 0;
            int cashBox = 0;
            int moneyGift = 10;
            for (int burthday = 1; burthday <= currentAge; burthday++)
            {
                int remainder = burthday % 2;
                bool isOdd = remainder == 1;

                if (isOdd)
                {
                    toysNum++;
                }
                else
                {
                    cashBox += moneyGift;
                    moneyGift += 10;
                    cashBox--;
                }
            }
            double totalFromToys = toysNum * ToyPrice;
            double totalFromBurthDay = totalFromToys + cashBox;

            if (totalFromBurthDay >= washingMachinePrice)
            {
                double N = totalFromBurthDay - washingMachinePrice;
                Console.WriteLine($"Yes! {N:f2}");
            }
            else
            {
                double M = washingMachinePrice - totalFromBurthDay;
                Console.WriteLine($"No! {M:f2}");
            }
        }
    }
}
