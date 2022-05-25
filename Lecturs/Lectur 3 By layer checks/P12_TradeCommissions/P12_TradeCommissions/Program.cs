using System;

namespace P12_TradeCommissions
{
    internal class Program
    {
        static void Main()
        {
            string town = Console.ReadLine();
            double salesVolume = double.Parse(Console.ReadLine());
            double saleVolumeTotal = 0;
            if (salesVolume < 0 )
            {
                Console.WriteLine("error");
            }
            switch (town)
            {
                case "Sofia":
                    if (salesVolume >0 && salesVolume <= 500)
                    {
                        saleVolumeTotal = salesVolume* 0.05;
                        Console.WriteLine($"{saleVolumeTotal:f2}");
                    }
                    if (salesVolume > 500 && salesVolume <= 1000)
                    {
                        saleVolumeTotal = salesVolume * 0.07;
                        Console.WriteLine($"{saleVolumeTotal:f2}");
                    }
                    if (salesVolume > 1000 && salesVolume <= 10000)
                    {
                        saleVolumeTotal = salesVolume * 0.08;
                        Console.WriteLine($"{saleVolumeTotal:f2}");
                    }
                    if (salesVolume > 10000)
                    {
                        saleVolumeTotal = salesVolume * 0.12;
                        Console.WriteLine($"{saleVolumeTotal:f2}");
                    }
                    break;
                case "Varna":
                    if (salesVolume > 0 && salesVolume <= 500)
                    {
                        saleVolumeTotal = salesVolume * 0.045;
                        Console.WriteLine($"{saleVolumeTotal:f2}");
                    }
                    if (salesVolume > 500 && salesVolume <= 1000)
                    {
                        saleVolumeTotal = salesVolume * 0.075;
                        Console.WriteLine($"{saleVolumeTotal:f2}");
                    }
                    if (salesVolume > 1000 && salesVolume <= 10000)
                    {
                        saleVolumeTotal = salesVolume * 0.10;
                        Console.WriteLine($"{saleVolumeTotal:f2}");
                    }
                    if (salesVolume > 10000)
                    {
                        saleVolumeTotal = salesVolume * 0.13;
                        Console.WriteLine($"{saleVolumeTotal:f2}");
                    }
                    break;
                case "Plovdiv":
                    if (salesVolume > 0 && salesVolume <= 500)
                    {
                        saleVolumeTotal = salesVolume * 0.055;
                        Console.WriteLine($"{saleVolumeTotal:f2}");
                    }
                    if (salesVolume > 500 && salesVolume <= 1000)
                    {
                        saleVolumeTotal = salesVolume * 0.08;
                        Console.WriteLine($"{saleVolumeTotal:f2}");
                    }
                    if (salesVolume > 1000 && salesVolume <= 10000)
                    {
                        saleVolumeTotal = salesVolume * 0.12;
                        Console.WriteLine($"{saleVolumeTotal:f2}");
                    }
                    if (salesVolume > 10000)
                    {
                        saleVolumeTotal = salesVolume * 0.145;
                        Console.WriteLine($"{saleVolumeTotal:f2}");
                    }
                    break;
                default:
                   if (town != "Plovdiv" || town != "Sofia" || town != "Varna" && salesVolume > 0)      
                    {
                        Console.WriteLine("error");
                    }
                    break;

            }
                  
            
        }
    }
}
