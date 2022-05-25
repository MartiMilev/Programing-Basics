using System;

namespace P04_InchesToCentimeters
{
    internal class Program
    {
        static void Main()
        {
            double inch = double.Parse(Console.ReadLine());
            inch = inch * 2.54;
            Console.WriteLine(inch);
        }
    }
}
