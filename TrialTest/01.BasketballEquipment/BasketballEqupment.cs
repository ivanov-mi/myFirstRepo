using System;

class BasketballEqupment
{
    static void Main()
    {
        int annualFee = int.Parse(Console.ReadLine());
        double snеakers= 0.6 * annualFee;
        double outfit  = 0.8 * snеakers;
        double ball = 0.25 * outfit;
        double accessories = 0.2 * ball;

        Console.WriteLine("{0:F2}", (double)annualFee + snеakers + outfit + ball + accessories);
        
            }
}

