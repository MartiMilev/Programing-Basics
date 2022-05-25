using System;

namespace _04_Walking
{
    internal class Program
    {
        static void Main()
        {
            int stepHave = 0;
                bool stepOk = false;
                bool stepNotOK = false;
                int steps;

            while(true)
            {
                string goinghome = Console.ReadLine();

                if (goinghome == "Going home")
                {

                    int stepsToHome =int.Parse(Console.ReadLine());
                    stepHave+=stepsToHome;

                    if (stepHave <10000)
                    {

                        stepNotOK = true;
                        break;
                    }
                    else
                    {
                        stepOk = true;
                        break;
                    }
                    
                }

                steps = int.Parse(goinghome);
                stepHave += steps;

                if (stepHave >= 10000)
                {

                    stepOk = true;
                    break;
                }
                
            }
            if (stepOk)
            {

                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{stepHave - 10000} steps over the goal!");
            }

            if (stepNotOK)

            {
                Console.WriteLine($"{10000-stepHave} more steps to reach goal.");
            }
        }
    }
}
