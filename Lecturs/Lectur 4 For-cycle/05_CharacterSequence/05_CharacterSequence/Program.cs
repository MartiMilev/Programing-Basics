using System;

namespace _05_CharacterSequence
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char latter = input[i];
                Console.WriteLine(latter);
            }
        }
    }
}
