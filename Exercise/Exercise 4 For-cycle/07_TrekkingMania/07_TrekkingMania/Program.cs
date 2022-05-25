using System;

namespace _07_TrekkingMania
{
    internal class Program
    {
        static void Main()
        {
            int group = int.Parse(Console.ReadLine());
            int totalFromMusala = 0 ;
            int totalFromMonblan = 0;
            int totalFromKalimandjaro = 0;
            int totalFromK2 = 0;
            int totalFromEverest = 0;
            int allMem=0 ;


            for (int i = 0; i < group; i++)
            {
                int groupMem = int.Parse(Console.ReadLine());

                if (groupMem <= 5)
                {
                    totalFromMusala+=groupMem ;
                }
                else if (groupMem  >5 && groupMem <=12)
                {
                    totalFromMonblan+=groupMem ;
                }
                else if (groupMem >12 && groupMem <=25)
                {
                    totalFromKalimandjaro+=groupMem ;
                }
                else if (groupMem >25 && groupMem <=40)
                {
                    totalFromK2+=groupMem;
                }
                else if (groupMem >=40)
                {
                    totalFromEverest+=groupMem;
                }
                allMem += groupMem;
            }
            double totalPeopleFromMusala = totalFromMusala/(double)allMem*100;
            double totalPeopleFromMonblan = totalFromMonblan /(double) allMem * 100;
            double totalPeopleFromKalimandjaro = totalFromKalimandjaro/(double)allMem * 100;
            double totalPeopleFromK2 = totalFromK2/(double)allMem * 100;
            double totalPeopleFromEverest = totalFromEverest/(double)allMem * 100;

            Console.WriteLine($"{totalPeopleFromMusala:f2}%");
            Console.WriteLine($"{totalPeopleFromMonblan:f2}%");
            Console.WriteLine($"{totalPeopleFromKalimandjaro:f2}%");
            Console.WriteLine($"{totalPeopleFromK2:f2}%");
            Console.WriteLine($"{totalPeopleFromEverest:f2}%");

        }
    }
}
