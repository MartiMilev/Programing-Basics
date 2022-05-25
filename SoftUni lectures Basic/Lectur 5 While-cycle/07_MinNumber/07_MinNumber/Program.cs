using System;

namespace _07_MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
                int maxNumber = int.MaxValue;
            while (value != "Stop")
            {
                int minNumber = int.Parse(value);
                if (minNumber < maxNumber)
                {
                    maxNumber = minNumber;
                }
            value = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
