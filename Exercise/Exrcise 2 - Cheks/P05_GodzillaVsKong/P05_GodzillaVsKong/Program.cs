using System;

namespace P05_GodzillaVsKong
{
    internal class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());
            double costPrice;
            double endPrice;

            double decor = budget * 0.1; //Пресмята колко ще струва декора
            double clothesPriceForAll = clothesPrice * extras; //цена за всички облекла
            endPrice = clothesPriceForAll + decor; //цена за всичко (декор + дрехи)
            Math.Abs(costPrice = budget- endPrice); //пресмята колко ще хартисат/ недостигат
            if (extras > 150) //ако статистите са над 150
            {
                double percentClothes = clothesPriceForAll * 0.1; //изчисляваме колко пари ще се смъкнат (облекла)
                double clothesEndPrice = clothesPriceForAll - percentClothes; // изваждаме тези пари от цената (облекла)
                endPrice = clothesEndPrice + decor  ; //крайната цена 
                Math.Abs(costPrice = budget -endPrice);
            } 

            if (endPrice > budget)
            {
                costPrice = endPrice - budget ;
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs "+($"{costPrice:f2}")+" leva more.");
            }
            else if (budget > endPrice)
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with " + ($"{costPrice:f2}") + " leva left.");
            }
        }
    }
}

