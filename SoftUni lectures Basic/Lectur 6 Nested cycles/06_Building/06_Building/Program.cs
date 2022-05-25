using System;

namespace _06_Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int currentFloar =floors; currentFloar >=1; currentFloar--)
            {
                for (int currentRooms = 0; currentRooms < rooms; currentRooms++)
                {
                    if (currentFloar==floors)
                    {
                        Console.Write($"L{currentFloar}{currentRooms} ");
                    }
                    else if (currentFloar %2==0)
                    {
                        Console.Write($"O{currentFloar}{currentRooms} ");
                    }
                    else
                    {
                        Console.Write($"A{currentFloar}{currentRooms} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
