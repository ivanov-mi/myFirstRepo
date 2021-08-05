using System;

public class FootballScores
{
    public static void Main()
    {
        string firstGame = Console.ReadLine();
        string secondGame = Console.ReadLine();
        string thirdGame = Console.ReadLine();

        int won = 0;
        int lose = 0;
        int draw = 0;

        if (firstGame[0] > firstGame[2])
        {
            won++;
        }
        else if (firstGame[0] == firstGame[2])
        {
            draw++;
        }
        else
        {
            lose++;
        }

        if (secondGame[0] > secondGame[2])
        {
            won++;
        }
        else if (secondGame[0] == secondGame[2])
        {
            draw++;
        }
        else
        {
            lose++;
        }

        if (thirdGame[0] > thirdGame[2])
        {
            won++;
        }
        else if (thirdGame[0] == thirdGame[2])
        {
            draw++;
        }
        else
        {
            lose++;
        }

        Console.WriteLine("Team won {0} games.", won);
        Console.WriteLine("Team lost {0} games.", lose);
        Console.WriteLine("Drawn games: {0}", draw);
    }
}