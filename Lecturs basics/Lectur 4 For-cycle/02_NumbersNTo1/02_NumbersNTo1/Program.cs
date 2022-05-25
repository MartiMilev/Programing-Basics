using System;

namespace _02_NumbersNTo1
{
    internal class Program
    {
        static void Main()
        {
             int N = int.Parse(Console.ReadLine());
            for (int i = N; i >= 1; i--) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
