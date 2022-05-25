using System;

namespace P04_PersonalTitles
{
    internal class Program
    {
        static void Main()
        {
            double year = double.Parse(Console.ReadLine());   
            string sex = Console.ReadLine();
            if (sex == "f" )
            {
                if (year >=16)
                Console.WriteLine("Ms.");
                else
                {
                    Console.WriteLine("Miss");
                }
                    
            }
            if (sex == "m")
            {
                if (year >=16)
                {
                    Console.WriteLine("Mr.");
                    
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
        }
    }
}
