using System;


class ShootingDay
{
    static void Main()
    {
        int timeForShooting = int.Parse(Console.ReadLine());
        int numbersOfScenes = int.Parse(Console.ReadLine());
        int timeForAScene = int.Parse(Console.ReadLine());

        if (0.85* timeForShooting - numbersOfScenes*timeForAScene >= 0)
        {
            Console.WriteLine("You manager to finish the movie ont time! You have {0} minutes left!", (int)Math.Round((0.85 * timeForShooting - numbersOfScenes * timeForAScene)));
        }
        else
        {
            Console.WriteLine("Time is up! To complete the movie you need {0} minutes.", (int)Math.Round(Math.Abs(0.85 * timeForShooting - numbersOfScenes * timeForAScene)));
        }
    }
}

