using System;

namespace P08_Basketball
{
    internal class Program
    {
        static void Main()
        {
            int PriceForYear = int.Parse(Console.ReadLine());

            double shoes = 0.4;
            double PriceShoes =PriceForYear - PriceForYear * shoes  ;
            double clothes =  0.2;
            double PriceClothes = PriceShoes - PriceShoes * clothes ;
            double Ball ;
            double PriceBall =  PriceClothes / 4 ;
            double Acaccessory ;
            double PriceAccessory = PriceBall / 5;
            double TotalValue;
            TotalValue = PriceForYear + PriceShoes + PriceClothes + PriceBall + PriceAccessory ;
            Console.WriteLine(TotalValue);


        }
    }
}
