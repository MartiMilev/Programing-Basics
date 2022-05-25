using System;

namespace _08_Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfStudent = Console.ReadLine();
            int skusan = 0;
            int klas = 1;
            double sumOcenki=0;

            for (int level = 1; level <= 12; level++)
            {
                double ocenka = double.Parse(Console.ReadLine());

                if (ocenka >= 4.00)
                {
                    klas++;
                    sumOcenki += ocenka;
                }
                else
                {

                    skusan++;
                    if (skusan == 2)
                    {
                        Console.WriteLine($"{nameOfStudent} has been excluded at {klas} grade");
                        break;
                    }
                }
                 


            }
            if (skusan <2)
            {
            Console.WriteLine($"{nameOfStudent} graduated. Average grade: {(sumOcenki/12):f2}");
            }
        }
    }
}
