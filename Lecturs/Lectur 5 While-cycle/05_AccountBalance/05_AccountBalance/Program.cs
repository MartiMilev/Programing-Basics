using System;

namespace _05_AccountBalance
{
    internal class Program
    {
        static void Main()
        {
            double balance = 0;

            while (true)
            {
                string text = Console.ReadLine();
                if (text == "NoMoreMoney")
                {
                break;

                }
            double money = double.Parse(text);    
            if (money <0)
            {
                Console.WriteLine("Invalid operation!");
                break;
            }
            balance+=money;
                Console.WriteLine($"Increase: {money:f2}");
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
