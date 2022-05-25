using System;

namespace school
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pen = double.Parse(Console.ReadLine());
            pen = pen * 5.80;
            double markers = double.Parse(Console.ReadLine());
            markers = markers * 7.20;
            double preparations = double.Parse(Console.ReadLine());
            preparations = preparations * 1.20;
            double percent = double.Parse(Console.ReadLine());
            percent = percent / 100;
            double price = pen + markers + preparations;
            double totalDiscount;
            totalDiscount = (pen + markers + preparations) * percent;
            double totalPrice;
            totalPrice = price - totalDiscount ;
            Console.WriteLine(totalPrice);
            
        }
    }
}
