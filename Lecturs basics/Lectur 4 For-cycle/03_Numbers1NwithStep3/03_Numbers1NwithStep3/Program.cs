﻿using System;

namespace _03_Numbers1NwithStep3
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i=1; i<=N; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
