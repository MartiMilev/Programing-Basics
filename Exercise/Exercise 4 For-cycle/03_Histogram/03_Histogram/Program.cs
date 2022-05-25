using System;

namespace _03_Histogram
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num199 = 0;
            int num399 = 0;
            int num599 = 0;
            int num799 = 0;
            int num800 = 0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num >=1 && num <= 199)
                {
                    num199++;
                }
                else if (num>199 && num<=399)
                {
                    num399++;
                }
                else if (num >399 && num<=599)
                {
                    num599++;
                }
                else if (num>599 && num<=799)
                {
                    num799++;
                }
                else if (num>799)
                {
                    num800++;
                }

            }
                double percentNum199 = num199 /(double)n*100;
                double percentNum399 = num399 /(double)n*100;
                double percentNum599 = num599 / (double)n*100;
                double percentNum799 = num799 / (double)n*100;
                double percentNum800 = num800 / (double)n*100;


            Console.WriteLine($"{percentNum199:f2}%");
            Console.WriteLine($"{percentNum399:f2}%");
            Console.WriteLine($"{percentNum599:f2}%");
            Console.WriteLine($"{percentNum799:f2}%");
            Console.WriteLine($"{percentNum800:f2}%");

        }
    }
}
