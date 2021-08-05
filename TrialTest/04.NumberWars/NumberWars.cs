using System;

public class NumberWars
{
    public static void Main()
    {
        string firstPlayer = Console.ReadLine();
        string secondPlayer = Console.ReadLine();

        bool numberWar = false;
        int scoreFirstPlayer = 0;
        int scoreSecondPlayer = 0;
        int winnerPoints = 0;
        string winner = string.Empty;

        while (true)
        {
            // Input
            string inputString = Console.ReadLine();
            if (inputString == "End of game")
            {
                break;
            }

            int firstPlayerCard = Convert.ToInt32(inputString);

            inputString = Console.ReadLine();
            if (inputString == "End of game")
            {
                break;
            }

            int secondPlayerCard = Convert.ToInt32(inputString);

            // Game Logic
            if (numberWar)
            {
                if (firstPlayerCard > secondPlayerCard)
                {
                    winner = firstPlayer;
                    winnerPoints = scoreFirstPlayer;                    
                }
                else if (firstPlayerCard < secondPlayerCard)
                {
                    winner = secondPlayer;
                    winnerPoints = scoreSecondPlayer;
                    break;
                }
            }
            else if (!numberWar)
            {
                if (firstPlayerCard > secondPlayerCard)
                {
                    scoreFirstPlayer += (int)firstPlayerCard - (int)secondPlayerCard;
                }
                else if (firstPlayerCard < secondPlayerCard)
                {
                    scoreSecondPlayer += (int)secondPlayerCard - (int)firstPlayerCard;
                }
                else if (firstPlayerCard == secondPlayerCard)
                {
                    numberWar = true;
                }
            }
        }

        // Print
        if (numberWar)
        {
            Console.WriteLine("Number wars!");
            Console.WriteLine("{0} is winner with {1} points", winner, winnerPoints);
        }
        else
        {
            Console.WriteLine("{0} has {1} points", firstPlayer, scoreFirstPlayer);
            Console.WriteLine("{0} has {1} points", secondPlayer, scoreSecondPlayer);
        }                
    }
}