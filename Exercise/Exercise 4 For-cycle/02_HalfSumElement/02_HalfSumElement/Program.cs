using System;

namespace _02_HalfSumElement
{
    internal class Program
    {
        static void Main()
        {
            int sum = 0;
            int max = int.MinValue;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;
                if (num > max)
                {
                    max = num;
                }

            }
                int sumWithoutMaxNum = sum - max;
                if (max == sumWithoutMaxNum)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Sum = " + max);
                }
                else
                {
                    int diff = Math.Abs(max - sumWithoutMaxNum);
                    Console.WriteLine("No");
                    Console.WriteLine("Diff = " + diff);
                }
        }
    }
}
