using System;

namespace _02_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string username = Console.ReadLine();
            string password = Console.ReadLine();

            while (true)
            {
                string passwordError= Console.ReadLine();
                if (passwordError == password)
                {
                    Console.WriteLine("Welcome " + username +"!");
                    break;
                }
            }
        }
    }
}
