using System;

public class HighJump
{
    public static void Main()
    {
        int desirableHeight = int.Parse(Console.ReadLine());

        int currentHeight = desirableHeight - 30;
        int totalAttemps = 0;
        int foul = 0;
        bool successfullWorkout = false;

        while (foul < 3 && !successfullWorkout)
        {
            totalAttemps++;

            int currentAttempt = int.Parse(Console.ReadLine());

            if (currentAttempt > currentHeight)
            {
                currentHeight += 5;
                foul = 0;
            }
            else
            {
                foul++;
            }

            if (currentHeight > desirableHeight)
            {
                successfullWorkout = true;
            }
        }

        if (successfullWorkout)
        {
            Console.WriteLine(
                "Tihomir succeeded, he jumped over {0}cm after {1} jumps.", 
                desirableHeight, 
                totalAttemps);
        }
        else if (!successfullWorkout)
        {
            Console.WriteLine(
                "Tihomir failed at {0}cm after {1} jumps.", 
                currentHeight, 
                totalAttemps);
        }
    }
}