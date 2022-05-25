using System;

namespace P07__Shopping
{
    internal class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ramMemory = int.Parse(Console.ReadLine());

            int videocardsPrice = videocards * 250; //цена за всички карти
            double processorsPrice = (videocardsPrice * 0.35) * processors; //цена за всички процесори
            double ramMemoryPrice = (videocardsPrice * 0.1) * ramMemory; // цена на РАМ;
            double price = videocardsPrice + processorsPrice + ramMemoryPrice; // обща цена 
            double endPrice; // финална цена
            double difference; //разлика
            double endPriceWithPercent; // крайна цена с процент (видеокарти > процесори)

            if (videocards > processors && price < budget) // ако видеокартите са повече от процесорите и цената е по малка от бюджета
            {
                endPriceWithPercent = price * 0.15; // пресмята процента
                endPrice = price - endPriceWithPercent; // пресмята цената без процента
                difference = budget - endPrice; // пресмята разликата
                Console.WriteLine("You have " + ($"{difference:f2}") + " leva left!"); // изписва на конзолата резултата
            }

            else if (videocards > processors && price > budget) // видеокартите са повече от процесорите и цената е по-голяма от бюджета
            {
                endPriceWithPercent = price * 0.15; // пресмята процента
                endPrice = price - endPriceWithPercent; // пресмята цената без процента
                difference = endPrice - budget; // пресмята разликата
                Console.WriteLine("Not enough money! You need " + ($"{difference:f2}") + " leva more!"); // изписва на конзолата разликата

            }
            else if (price > budget) // ако цената е по-голяма от бюджета
            {
                difference = price - budget; // пресмята разликата
                Console.WriteLine("Not enough money! You need " + ($"{difference:f2}") + " leva more!"); // изписва на конзолата разликата
            }
            else if (price < budget) // ако цената е по-малка от бюджета
            {
                difference = budget - price; // пресмята бюджета
                Console.WriteLine("You have " + ($"{difference:f2}") + " leva left!"); //изписва разликата

            }
        }
        }
    }
