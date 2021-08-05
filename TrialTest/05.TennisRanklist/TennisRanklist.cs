using System;

public class TennisRanklist
{
    public static void Main()
    {
        int numberOfTournaments = int.Parse(Console.ReadLine());
        int startingPoints = int.Parse(Console.ReadLine());

        int points = 0;
        int winnedTournaments = 0;

        for (int i = 0; i < numberOfTournaments; i++)
        {
            string stageOfTournament = Console.ReadLine();

            switch (stageOfTournament)
            {
                case "W": 
                    points += 2000;  
                    winnedTournaments++;  
                    break;
                case "F": 
                    points += 1200; 
                    break;
                case "SF": 
                    points += 720; 
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine("Final points: {0}", startingPoints + points);
        Console.WriteLine("Average points: {0}", points / numberOfTournaments);
        Console.WriteLine("{0:F2}%", (double)winnedTournaments / numberOfTournaments * 100);
    }
}