using System;

namespace _06_MaxNumber
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            int bigestNumber = int.MinValue;

            while (command != "Stop")
            {
                int number = int.Parse(command);
                if (number > bigestNumber)
                {
                    bigestNumber = number;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(bigestNumber);
        }
    }
}
