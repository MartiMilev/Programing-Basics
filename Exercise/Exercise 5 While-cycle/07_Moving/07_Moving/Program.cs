using System;

namespace _07_Moving
{
    internal class Program
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            bool allDone = false;
            bool noMoreSpace = false;
            int spaceVolume = 0;
            int volume = width * height* length;

            while (true)
            {
                string done = Console.ReadLine();
                if (done =="Done")
                {
                    allDone = true;
                    break;
                }

                spaceVolume=int.Parse(done);
                volume -=spaceVolume;
                if (volume <=0)
                {
                    noMoreSpace = true;
                    break;
                }
            }
            if (allDone)
            {
                Console.WriteLine($"{volume } Cubic meters left.");
            }
            if (noMoreSpace)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            }
        }
    }
}
