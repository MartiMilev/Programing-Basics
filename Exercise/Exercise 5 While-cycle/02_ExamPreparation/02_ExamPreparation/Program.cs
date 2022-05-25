using System;

namespace _02_ExamPreparation
{
    internal class Program
    {
        static void Main()
        {
            int nezadovolitelniOcenki =0;
            int notGoodRating = int.Parse(Console.ReadLine());
            double niceOcenki = 0;
            double ocenka = 0;
            string lastExam="";
            double ratingFromTeacher = 0;
            bool commandForEnd = false;
            while(true)
            {
                string nameOfExam = Console.ReadLine();
                if (nameOfExam == "Enough") 
                {
                    commandForEnd = true;
                    break;
                }
                 ratingFromTeacher = double.Parse(Console.ReadLine());

                if (ratingFromTeacher <=4.00)
                {
                    nezadovolitelniOcenki++;
                    if (nezadovolitelniOcenki ==notGoodRating)
                    {
                        Console.WriteLine($"You need a break, {nezadovolitelniOcenki} poor grades.");
                        break;
                    }
                }
                niceOcenki++;
                ocenka+=ratingFromTeacher;
                lastExam = nameOfExam;

            }
            if (commandForEnd)
            {

                    double finalOcenka = (ocenka / niceOcenki);
                    Console.WriteLine($"Average score: {(finalOcenka):f2}");
                    Console.WriteLine($"Number of problems: {niceOcenki}");
                    Console.WriteLine($"Last problem: {lastExam}");
            }


        }
    }
}
