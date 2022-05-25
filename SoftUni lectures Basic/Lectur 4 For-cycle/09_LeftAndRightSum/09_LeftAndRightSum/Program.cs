using System;

namespace _09_LeftAndRightSum
{
    internal class Program
    {
        static void Main()
        {
            int sum1 = 0;
            int sum2 = 0;   
            int finalSum=0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <n; i++)
            {
                int doubleNumber = int.Parse(Console.ReadLine());

                sum1 += doubleNumber;
            }
            for (int i = 0;i < n;i++)
            {
                int secondNumber = int.Parse(Console.ReadLine());

                sum2 += secondNumber;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = " + sum1);
            }
            else if (sum1 != sum2)
            {
                finalSum = sum2 - sum1;
                Console.WriteLine("No, diff = " + Math.Abs(finalSum));
            }
        }
    }
}
