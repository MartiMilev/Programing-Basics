using System;

namespace _04_SumofTwoNumbers
{
    internal class Program
    {
        static void Main()
        {
            int lowerNum = int.Parse(Console.ReadLine());
            int upperNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;
            for (int firstNum =lowerNum; firstNum <= upperNum; firstNum++)
            {
                for  (int secondNum =lowerNum; secondNum <= upperNum; secondNum++)
                {
                    combinations++;
                    if (firstNum + secondNum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({firstNum} + {secondNum} = {magicNum})");
                        return;
                    }
                    
                    
                }
            }
                        Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");

        }
    }
}
