using System;

namespace P07_DeliveryFood
{
    internal class Program
    {
        static void Main()
        {
            //Пилешко меню – 10.35 лв.
            //Меню с риба – 12.40 лв.
            //Вегетарианско меню – 8.15 лв.
            double chikenMenu = double.Parse(Console.ReadLine());
            double fishMenu = double.Parse(Console.ReadLine());
            double vegetableMenu = double.Parse(Console.ReadLine());

            double PriceChikenMenu = chikenMenu * 10.35;
            double PriceFishMenu = fishMenu * 12.40;
            double PriceVegetableMenu = vegetableMenu * 8.15;
            double dessert = 0.2;
            double delivery = 2.50;

            double order = PriceChikenMenu + PriceFishMenu + PriceVegetableMenu;
            double DessertPercent;
            DessertPercent = dessert * order;
            double totalPrice;
            totalPrice =  order + delivery + DessertPercent;
            Console.WriteLine(totalPrice);
           
        }
    }
}
