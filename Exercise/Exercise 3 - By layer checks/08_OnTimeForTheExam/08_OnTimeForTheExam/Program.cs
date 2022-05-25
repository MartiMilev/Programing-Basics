using System;

namespace _08_OnTimeForTheExam
{
    internal class Program
    {
        static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivelHour = int.Parse(Console.ReadLine());
            int arrivelMin = int.Parse(Console.ReadLine());

            int examTimeAsMinuts = examHour * 60 + examMin;
            int arrivelTimeAsMinuts = arrivelHour * 60 + arrivelMin;
            
            int differenceExamArrivel = examTimeAsMinuts - arrivelTimeAsMinuts;

            int differenceHoure = differenceExamArrivel / 60;
            int differenceMin = differenceExamArrivel % 60;

            if (differenceExamArrivel ==0)
            {
                Console.WriteLine("On time");
            }
            else if (differenceExamArrivel > 0)
            {
                if (differenceExamArrivel <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{differenceMin} minutes before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    if (differenceHoure <= 0)
                    { 
                    Console.WriteLine($"{differenceMin} minutes before the start");

                    }
                    else
                    {
                        Console.WriteLine($"{differenceHoure}:{differenceMin:d2} hours before the start");
                    }

                }
            }
            else if (differenceExamArrivel < 0)
            {
                if (differenceExamArrivel >= -59)
                {
                Console.WriteLine("Late");
                Console.WriteLine($"{Math.Abs(differenceMin)} minutes after the start");
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{Math.Abs(differenceHoure)}:{Math.Abs(differenceMin)} hours after the start");
                }
            }
            
        }
    }
}
