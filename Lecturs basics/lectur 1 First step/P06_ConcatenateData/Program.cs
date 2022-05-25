using System;

namespace P06_ConcatenateData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string femily = Console.ReadLine(); 
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine("You are " + name + " " + femily + ", a " + age +"-years old person from " + town +".");
        }
    }
}
