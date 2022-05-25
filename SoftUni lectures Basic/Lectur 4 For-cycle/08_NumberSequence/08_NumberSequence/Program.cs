using System;

namespace _08_NumberSequence
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber >=maxNumber)
                {
                    maxNumber = currentNumber;
                }
                if (currentNumber <minNumber)
                {
                    minNumber = currentNumber;
                }
            }
            Console.WriteLine("Max number: " +maxNumber);
            Console.WriteLine("Min number: " + minNumber);
        }
    }
}
