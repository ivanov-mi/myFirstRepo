using System;

public class Gymnastics
{
    public static void Main()
    {
        string country = Console.ReadLine();
        string apparatus = Console.ReadLine();

        double currentScore = 0;

        if (country == "Russia")
        {
            switch (apparatus)
            {
                case "ribbon": currentScore = 9.1 + 9.4; 
                    break;
                case "hoop": currentScore = 9.3 + 9.8; 
                    break;
                case "rope": currentScore = 9.6 + 9.0; 
                    break;
                default:
                    break;
            }
        }
        else if (country == "Bulgaria")
        {
            switch (apparatus)
            {
                case "ribbon": currentScore = 9.6 + 9.4; 
                    break;
                case "hoop": currentScore = 9.55 + 9.75; 
                    break;
                case "rope": currentScore = 9.5 + 9.4; 
                    break;
                default:
                    break;
            }
        }
        else if (country == "Italy")
        {
            switch (apparatus)
            {
                case "ribbon": currentScore = 9.2 + 9.5; 
                    break;
                case "hoop": currentScore = 9.45 + 9.35; 
                    break;
                case "rope": currentScore = 9.7 + 9.15; 
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine("The team of {0} get {1:F3} on {2}.", country, currentScore, apparatus);
        Console.WriteLine("{0:F2}%", (20 - currentScore) / 20 * 100);
    }
}