using System;

namespace P09_YardGreening
{
    internal class Program
    {
        static void Main()
        {
            int kvM = int.Parse(Console.ReadLine());
            double Percent = 0.18;
            double OneKvM = 7.61;
            double PriceKvM = (kvM * OneKvM) ;
            double PercentEnd = PriceKvM * Percent;
            double Project = (kvM * OneKvM) - PercentEnd;
            Console.WriteLine("The final price is: " + Project + " lv.");
            Console.WriteLine("The discount is: " + PercentEnd + " lv.");

        }
    }
}
