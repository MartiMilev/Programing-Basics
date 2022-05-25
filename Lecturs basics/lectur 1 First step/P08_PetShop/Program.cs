using System;

namespace P08_PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dog = double.Parse(Console.ReadLine());
            int cat = int.Parse(Console.ReadLine());

            double dogPrice = 2.5;
            int catPrice = 4;

            double finalPrice = (dog * dogPrice) + (cat * catPrice);
            Console.WriteLine(finalPrice + " lv." );
        }
    }
}
