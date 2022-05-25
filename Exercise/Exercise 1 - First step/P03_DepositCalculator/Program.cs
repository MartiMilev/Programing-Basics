using System;

namespace P03_DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            double deposit = int.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double purcent = double.Parse(Console.ReadLine());
             purcent = purcent / 100 ;
            double price = deposit + term * ((deposit * purcent) / 12);
            Console.WriteLine(price);
        }
    }
}
