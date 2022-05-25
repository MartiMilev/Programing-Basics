using System;

namespace P06_Repainting
{
    internal class Program
    {
        static void Main()
        {
            double nylonBags = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());    
            int thinner = int.Parse(Console.ReadLine());
            double timeForWork = int.Parse(Console.ReadLine());

            double forBags = 0.40;
            nylonBags = (nylonBags + 2) * 1.5 ;
            paint = (paint * 1.1 ) * 14.50;
            thinner = thinner * 5;

            double PriceForMaterials;
            double priceForWork;
            double percentForWork = 0.3 ;
            PriceForMaterials = nylonBags + paint + thinner + forBags  ;
            priceForWork = (PriceForMaterials * percentForWork)*timeForWork ;
            double totalPriceForWork;
            totalPriceForWork = priceForWork + PriceForMaterials;
            Console.WriteLine(totalPriceForWork);


        }
    }
}
