using System;

namespace _01_Number_Pyramid
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool isBigger = false;
            int  current = 1;

            for (int rolls = 1; rolls <= n; rolls++)
            {
                for (int cols = 1; cols <= rolls; cols++)
                {
                    if (current >n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current +" ");
                    current++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
