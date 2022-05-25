using System;

namespace P03_EvenorOdd
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            if (num %  2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
