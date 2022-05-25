using System;

namespace _07_HotelRoom
{
    internal class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int stay = int.Parse(Console.ReadLine());
            double price = 0;
            double totalPriceStudio=0;
            double totalPriceApartment = 0;
            int Studio = 0;
            int Apartment = 0;


            if (Studio == 0)
            {


                if (month == "May" || month == "October")
                {
                    price = 50;
                    if (stay >= 7 && stay < 14)
                    {
                        totalPriceStudio = stay * price;
                        totalPriceStudio *= 0.95;
                    }
                    else if (stay > 14)
                    {
                        totalPriceStudio = stay * price;
                        totalPriceStudio *= 0.7;
                    }
                }
                else if (month == "June" || month == "September")
                {
                    price = 75.20;
                    totalPriceStudio = stay * price;
                    if (stay > 14)
                    {
                        totalPriceStudio *= 0.8;
                    }
                }
                else if (month == "July" || month == "August")
                {
                    price = 76;
                    totalPriceStudio = stay * price;
                }

            }
            if (Apartment == 0)
            {



                if (month == "May" || month == "October")
                {
                    price = 65;
                    totalPriceApartment = stay * price;
                }
                else if (month == "June" || month == "September")
                {
                    price = 68.70;
                    totalPriceApartment = stay * price;
                }
                else if (month == "July" || month == "August")
                {
                    price = 77;
                    totalPriceApartment = stay * price;
                }
                if (stay > 14)
                {
                    totalPriceApartment *= 0.9;
                }
            }
            
               Console.WriteLine("Apartment: " + $"{totalPriceApartment:f2}" + " lv.");
               Console.WriteLine("Studio: " + $"{totalPriceStudio:f2}" + " lv.");

        }
    }
}
