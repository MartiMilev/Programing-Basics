using System;

namespace _01_OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookLove = Console.ReadLine();
            bool findBook = (false);
            bool cannotFindBook = (false);
            int booksearch = 0;


            while (true)
            {
               string books = Console.ReadLine();

                if (bookLove == books)
                {
                    findBook = true;
                    break;
                }
                else if (books =="No More Books")
                {
                    cannotFindBook = true;
                    break;
                }
                booksearch++;
            }
            if (findBook)
            {
                Console.WriteLine($"You checked {booksearch} books and found it.");
            }

            if (cannotFindBook)
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {booksearch} books.");
            }
        }
    }
}
