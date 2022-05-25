using System;

namespace _09_SkiTrip
{
    internal class Program
    {
        static void Main()
        {
            int dayOfStay = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string rate = Console.ReadLine();
            double price;
            double priceForVacantion=0;
            int overnight;

            switch (type)
            {
                case "room for one person":
                    overnight = dayOfStay - 1;
                    price = 18.00;
                    priceForVacantion = price * overnight;
                    break;
                case "apartment":
                    price = 25.00;
                    overnight = dayOfStay - 1;
                    priceForVacantion = price * overnight;

                    if (dayOfStay < 10)
                    {
                        priceForVacantion *= 0.7;
                    }
                    else if(dayOfStay >= 10 && dayOfStay <= 15)
                    {
                        priceForVacantion *= 0.65;

                    }
                    else
                    {
                        priceForVacantion *= 0.5;
                    }
                    break;
                case "president apartment":
                    price = 35.00;
                    overnight = dayOfStay - 1;
                    priceForVacantion = price * overnight;
                    if (dayOfStay < 10)
                    {
                        priceForVacantion *= 0.9;
                    }
                    else if (dayOfStay >= 10 && dayOfStay < 15)
                    {
                        priceForVacantion *= 0.85;

                    }
                    else
                    {
                        priceForVacantion *= 0.8;
                    }


                    break;

            }
                    if (rate == "positive")
                    {
                        priceForVacantion *= 1.25;
                    }
                    else if (rate == "negative")
                    {
                        priceForVacantion *= 0.9;
                    }
            Console.WriteLine($"{priceForVacantion:f2}");
        }
    }
}
