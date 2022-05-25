using System;

namespace P01_SumSeconds
{
    internal class Program
    {
        static void Main()
        {
            int Time1 = int.Parse(Console.ReadLine());
            int Time2 = int.Parse(Console.ReadLine());
            int Time3 = int.Parse(Console.ReadLine());

            int allTime = Time1 + Time2 + Time3;

            int Minuts = allTime / 60;
            int seconds = allTime % 60;
                if (seconds < 10)
            {
                Console.WriteLine(Minuts + ":" +  ($"{seconds:f-2}"));
            }
                else
            {
                Console.WriteLine(Minuts + ":" + seconds);
            }
        }
    }
}
