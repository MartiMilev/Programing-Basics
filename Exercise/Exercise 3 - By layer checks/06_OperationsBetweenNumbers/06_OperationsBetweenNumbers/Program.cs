using System;

namespace _06_OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main()
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            char simbolN = char.Parse(Console.ReadLine());
            double result=0;
            string chetenNecheten = null;

            switch (simbolN)
            {
                case '+':
                    result = N1 + N2;
                    if (result % 2 ==0)
                    {
                        chetenNecheten = "even";
                    }
                    else
                    {
                        chetenNecheten = "odd";
                    }
                    break;

                    case '-':
                    result = N1 - N2;
                    if (result % 2 == 0)
                    {
                        chetenNecheten = "even";
                    }
                    else
                    {
                        chetenNecheten = "odd";
                    }
                    break ;

                    case '*':
                    result = N1 * N2;
                    if (result % 2 == 0)
                    {
                        chetenNecheten = "even";
                    }
                    else
                    {
                        chetenNecheten = "odd";
                    }
                    break;

                case '/':
                    result = N1 / N2;
                    if (N1 ==0 || N2 == 0)
                    {
                        Console.WriteLine("Cannot divide " +  N1 + " by zero");
                    }
                    break;

                case '%':
                    result = N1 % N2;
                    if (N1 == 0 || N2 == 0)
                    {
                        Console.WriteLine("Cannot divide "+ N1 +" by zero");
                    }
                    break;

            }
            if (simbolN == '+')
            {
                Console.WriteLine(N1 + " + "+ N2 + " = " + result + " - " + chetenNecheten);
            }
            else if (simbolN == '-')
            {
                Console.WriteLine(N1 + " - " + N2 + " = " + result + " - " + chetenNecheten);
            }
            else if (simbolN=='*')
            {
                Console.WriteLine(N1 + " * " + N2 + " = " + result + " - " + chetenNecheten);
            }
            else if (simbolN=='/' && N2 !=0)
            {
                Console.WriteLine(N1 + " / " + N2 + " = " + $"{ result:f2}" );
            }
            else if (simbolN=='%' && N2 !=0)
            {
                Console.WriteLine(N1 + " % " + N2 + " = " + result);
            }
        }
    }
}
