using System;

namespace P04_Vacantion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int total;
            total = pages / hour / days;
            Console.WriteLine(total);
        }
    }
}
