using System;

namespace _01_ReadText
{
    internal class Program
    {
        static void Main()
        {

            while (true)
            {
            string command = Console.ReadLine();
                if (command == "Stop")
                {
                    break;
                }
                Console.WriteLine(command);
            }
        }
    }
}
