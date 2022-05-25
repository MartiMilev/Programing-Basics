using System;

namespace _08_TennisRanklist
{
    internal class Program
    {
        static void Main()
        {
            int numberOfTournaments = int.Parse(Console.ReadLine());
            int nachalenBroiPoints = int.Parse(Console.ReadLine());
            double pointFromTournament=0;
            double winnerTournirs = 0;

            for (int i = 1; i <= numberOfTournaments; i++)
            {
                     string etap = Console.ReadLine();
                switch(etap)
                {
                    case "W":
                        pointFromTournament += 2000;
                        winnerTournirs++;
                        break;
                    case "F":
                        pointFromTournament += 1200;
                        break;
                    case "SF":
                        pointFromTournament += 720;
                        break;
                }
            }
            double totalPoint = pointFromTournament + nachalenBroiPoints;
            Console.WriteLine($"Final points: {totalPoint}");

            double averageTournamentPoints =Math.Floor( pointFromTournament / numberOfTournaments);
            Console.WriteLine($"Average points: {averageTournamentPoints}");

            double purcentOfWinnerTournirs = winnerTournirs / numberOfTournaments * 100;
            Console.WriteLine($"{purcentOfWinnerTournirs:f2}%");
        }
    }
}
