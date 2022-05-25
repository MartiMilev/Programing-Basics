using System;

namespace P07_AreaOfFigures
{
    internal class Program
    {
        static void Main()
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double squareNum = double.Parse(Console.ReadLine());
                double S1 = squareNum * squareNum;
                Console.WriteLine(S1);
            }
             if (figure == "rectangle")
            {
                double rectangleNum1 = double.Parse(Console.ReadLine());
                double rectangleNum2 = double.Parse(Console.ReadLine());
                double S2 = rectangleNum1 * rectangleNum2 ;
                Console.WriteLine(S2);
            }
            if (figure == "circle")
            {
                double circleNum1 = double.Parse(Console.ReadLine());
                double S3 = circleNum1 * circleNum1 * Math.PI;
                Console.WriteLine($"{S3:f3}");
            }
            if (figure == "triangle")
            {
                double triangleNum1 = double.Parse(Console.ReadLine());
                double triangleNum2 = double.Parse(Console.ReadLine());
                double S4 = triangleNum1 * triangleNum2 / 2;
                Console.WriteLine($"{S4:f3}");
            }



        }
    }
}
