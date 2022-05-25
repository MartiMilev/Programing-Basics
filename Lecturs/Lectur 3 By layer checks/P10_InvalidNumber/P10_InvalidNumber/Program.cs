using System;

namespace P10_InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 0 || number <=200 && number >= 100)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
