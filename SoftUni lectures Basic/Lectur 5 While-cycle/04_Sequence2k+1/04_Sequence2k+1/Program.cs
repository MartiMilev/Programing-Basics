﻿using System;

namespace _04_Sequence2k_1
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1;

            while(k <= n)
            {
                Console.WriteLine(k);
                k = 2 * k + 1;
                
            }
        }
    }
}
