using System;

namespace _05_Salary
{
    internal class Program
    {
        static void Main()
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int penaltyFromFacebook = 150;
            int penaltyFromInstagram = 100;
            int penaltyFromReddit = 50;
            int penalty = 0;
            for (int i = 1; i <= openTabs; i++)
            {
                string tabs = Console.ReadLine();

                if (tabs =="Facebook")
                {
                    penalty +=penaltyFromFacebook;
                }
                else if (tabs =="Instagram")
                {
                    penalty += penaltyFromInstagram;
                }
                else if (tabs =="Reddit")
                {
                    penalty += penaltyFromReddit;
                }

                
            }
                salary -= penalty;
                if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
                else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
