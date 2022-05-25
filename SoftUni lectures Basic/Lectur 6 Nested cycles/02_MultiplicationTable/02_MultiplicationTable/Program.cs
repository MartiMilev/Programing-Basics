using System;

namespace _02_MultiplicationTable
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 1; i <=10 ; i++)
            {
                for (int j = 1; j <=10 ; j++)
                {
                    int a=i*j;
                    Console.WriteLine($"{i} * {j} = {a}");
                }
            }
        }
    }
}
