using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction firstFraction = new();
        Fraction secondFraction = new(4);
        Fraction thirdFraction = new(3, 4);

        Console.WriteLine(firstFraction.GetFractionString());

        secondFraction.SetTop(2);
        Console.WriteLine(secondFraction.GetFractionString());

        Console.WriteLine(thirdFraction.GetDecimalValue());
    }
}