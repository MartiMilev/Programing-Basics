using System;

namespace _03_SumNumbers
{
    internal class Program
    {
        static void Main()
        {
            int target = int.Parse(Console.ReadLine());
            int sum = 0;
            while (true)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum +=currentNumber;
                if (sum >= target)
                {
                    Console.WriteLine(sum);
                    break; 
                }
            }
        }
    }
}
