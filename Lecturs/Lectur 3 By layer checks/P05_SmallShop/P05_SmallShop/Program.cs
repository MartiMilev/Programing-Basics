using System;

namespace P05_SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            string town = Console.ReadLine();
            double broq = double.Parse(Console.ReadLine());
            double price = 0;
            if (town == "Sofia")
            {

                if (order == "coffee")
                {
                    price = broq * 0.50;
                }
                else if (order == "water")
                {
                    price = broq * 0.80;
                }
                else if (order == "beer")
                {
                    price = broq * 1.20;
                }
                else if (order == "sweets")
                {
                    price = broq * 1.45;
                }
                else if (order == "peanuts")
                {
                    price = broq * 1.60;
                }
                Console.WriteLine(price);
            }
                if (town == "Plovdiv")
                {

                    if (order == "coffee")
                    {
                        price = broq * 0.40;
                    }
                    else if (order == "water")
                    {
                        price = broq * 0.70;
                    }
                    else if (order == "beer")
                    {
                        price = broq * 1.15;
                    }
                    else if (order == "sweets")
                    {
                        price = broq * 1.30;
                    }
                    else if (order == "peanuts")
                    {
                        price = broq * 1.50;
                    }
                    Console.WriteLine(price);
                }

            if (town == "Varna")
            {

                if (order == "coffee")
                {
                    price = broq * 0.45;
                }
                else if (order == "water")
                {
                    price = broq * 0.70;
                }
                else if (order == "beer")
                {
                    price = broq * 1.10;
                }
                else if (order == "sweets")
                {
                    price = broq * 1.35;
                }
                else if (order == "peanuts")
                {
                    price = broq * 1.55;
                }
                Console.WriteLine(price);
            }
        }
    }
}
