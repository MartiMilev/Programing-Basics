using System;

namespace _04_TrainTheTrainers
{
    internal class Program
    {
        static void Main()
        {
            int numbersOfJury = int.Parse(Console.ReadLine());
            bool finish = false;
            double totalRating = 0;
            int numberOfRate = 0;
             while(true)
            {
            double totalRatingForOnePresent=0;
                string present= Console.ReadLine();
                if (present == "Finish")
                {
                    finish = true;
                    break;
                }

                for (int rate = 1; rate <= numbersOfJury; rate++)
                {
                    double ratingFromJury= double.Parse(Console.ReadLine());
                    totalRatingForOnePresent+=ratingFromJury;
                    totalRating += ratingFromJury;
                    numberOfRate++;
                }
                Console.WriteLine($"{present} - {(totalRatingForOnePresent / numbersOfJury):f2}.");
            }
             if (finish)
            {
                Console.WriteLine($"Student's final assessment is {(totalRating/numberOfRate):f2}. ");
            }
        }
    }
}
