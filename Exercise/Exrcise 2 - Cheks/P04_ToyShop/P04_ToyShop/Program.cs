using System;

namespace P04_ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double puzzelsPrice = 2.60;
            double barbiesPrice = 3.00;
            double bearsPrice = 4.10;
            double minersPrice = 8.20;
            double trucksPrice = 2.00;
            double priceForVacantion = double.Parse(Console.ReadLine());
            double numberOfPuzzels = double.Parse(Console.ReadLine());
            double numberOfBarbies = int.Parse(Console.ReadLine());
            double numberOfBears = double.Parse(Console.ReadLine());
            double numberOfMiners = double.Parse(Console.ReadLine());
            double numberOfTrucks = double.Parse(Console.ReadLine());

            double puzzelTotalPrice = numberOfPuzzels * puzzelsPrice;
            double barbiesTotalPrice = numberOfBarbies * barbiesPrice;
            double bearsTotalPrice = numberOfBears * bearsPrice;
            double minersTotalPrice = numberOfMiners * minersPrice;
            double truckTotalPrice = numberOfTrucks * trucksPrice;

            double totalToys = numberOfPuzzels + numberOfBarbies + numberOfBears + numberOfMiners + numberOfTrucks; // общ брой играчки
            double commonToAllPrice = puzzelTotalPrice + barbiesTotalPrice + bearsTotalPrice + minersTotalPrice + truckTotalPrice; //общ брой пари

            double moneyWithRentPercent; // наем 10%
            double totalMoneyWithOutRentPercent; //крайни пари (изчистен наем)
            double rentPercent = 0.1;
            double discountPercent = 0.25;
            double moneyWithDiscountPercent; // над 50 броя играчки (25% намаление)
            double totalMoneyWitOutDiscountPercent; // крайни пари (след изчисляване на отстъпката(25%) )
            double remainingMoney; // оставаща наличност

            if (totalToys >= 50)
            {
                moneyWithDiscountPercent = commonToAllPrice * discountPercent; // изчислявам отстъпката за играчки 
                totalMoneyWitOutDiscountPercent = commonToAllPrice - moneyWithDiscountPercent; // сума с приспадната отстъпка

                moneyWithRentPercent = totalMoneyWitOutDiscountPercent * rentPercent; // изчислявам колко е наема 
                totalMoneyWithOutRentPercent = totalMoneyWitOutDiscountPercent - moneyWithRentPercent; // сумата с приспаднат наем 

                if (totalMoneyWithOutRentPercent > priceForVacantion) // ако парите са повече от цената за ваканцията 
                {
                    remainingMoney = totalMoneyWithOutRentPercent - priceForVacantion; // намираме колко пари ни остават 
                    Console.WriteLine("Yes! " + ($"{remainingMoney:f2}") +" lv left."); // извеждаме резултата
                }
                else if (totalMoneyWithOutRentPercent < priceForVacantion) // ако парите са по-малко от ваканцията
                {
                    remainingMoney = priceForVacantion - totalMoneyWithOutRentPercent; //намираме колко не ни достигат 
                    Console.WriteLine("Not enough money! " + ($"{remainingMoney:f2}") +" lv needed."); // извеждаме резултата
                }
            }
            else // ако играчките са по-малко от 50
            {
                moneyWithRentPercent = commonToAllPrice * rentPercent; // изчислявам колко е наема 
                totalMoneyWithOutRentPercent = commonToAllPrice - moneyWithRentPercent; // сумата с приспаднат наем 
                remainingMoney = totalMoneyWithOutRentPercent - priceForVacantion;

                if (totalMoneyWithOutRentPercent >= priceForVacantion) //ако парите са повече или равни на цената за ваканцията
                {
                    Console.WriteLine("Yes! " + ($"{remainingMoney:f2}") +" lv left."); // извеждаме резултата

                }
                else // ако парите са по-малко от нужното 
                {
                    remainingMoney = priceForVacantion - totalMoneyWithOutRentPercent; //изчисляваме колко не ни достигат
                    Console.WriteLine("Not enough money! " + ($"{remainingMoney:f2}") +" lv needed."); // извеждаме резултата
                }
            }    

        }
    }
}
