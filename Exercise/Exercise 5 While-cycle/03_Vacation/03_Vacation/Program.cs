using System;

namespace _03_Vacation
{
    internal class Program
    {
        static void Main()
        {
            double moneyForVacancion = double.Parse(Console.ReadLine());
            double moneyHave = double.Parse(Console.ReadLine());
            bool saveMoney = false;
            int days = 0;
            bool daysEnd = false;

            while (true)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;
                if (days == 5)
                {
                    daysEnd = true;
                    break;
                }
                if (moneyHave < 0)
                {
                    moneyHave = 0;
                }
                if (action == "save")
                {
                    moneyHave += money;

                }
                if (moneyHave >= moneyForVacancion)
                {
                    saveMoney = true;
                    break;
                }
                else if (action == "spend")
                {
                    moneyHave -= money;
                }

                if (daysEnd)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(days);
                    break;
                }
            }
            if (saveMoney)
            {
                Console.WriteLine($"You saved the money for {days} days. ");
            }
        }
    }
}
