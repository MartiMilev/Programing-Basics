﻿using System;

namespace _01_Clock
{
    internal class Program
    {
        static void Main()
        {
            for (int hour =0 ; hour < 24; hour++)
            {
                for (int minute =0 ; minute < 60 ; minute++)
                {
                    Console.WriteLine($"{hour}:{minute}");
                }
            }
        }
    }
}
