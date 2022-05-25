using System;

namespace _06_Oscars
{
    internal class Program
    {
        static void Main()
        {
            string actorName = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int juryMem = int.Parse(Console.ReadLine());

            double totalPoints = pointsFromAcademy;
            double totalToNominatePoints = 1250.5;

            for (int i = 1; i <= juryMem; i++)
            {
                string juryName = (Console.ReadLine());
                double juryPoints = double.Parse(Console.ReadLine());
                double juruNamePoints = juryName.Length* juryPoints /2;
                totalPoints+=juruNamePoints;

                if (totalPoints >=totalToNominatePoints)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:f1}! ");
                    return;
                }
            }
            if (totalPoints < totalToNominatePoints)
            {
                double NotEnoughPoints = totalToNominatePoints - totalPoints;
                Console.WriteLine($"Sorry, {actorName } you need {NotEnoughPoints:f1} more!");
            }
        }
    }
}
