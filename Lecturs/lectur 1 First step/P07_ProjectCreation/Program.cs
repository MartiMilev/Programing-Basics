using System;

namespace P07_ProjectCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Artchitect = (Console.ReadLine());
            int timeForWork = int.Parse(Console.ReadLine());
            int Total = timeForWork * 3;
            Console.WriteLine("The architect " + Artchitect  + " will need " + Total +  " hours to complete " + timeForWork + " project/s. ");
        }
    }
}
