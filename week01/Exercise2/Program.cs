using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int gradePercantage = int.Parse(Console.ReadLine());

        char gradeLetter;
        string gradeSign;

        if (gradePercantage >= 90)
        {
            gradeLetter = 'A';
        }
        else if (gradePercantage >= 80)
        {
            gradeLetter = 'B';
        }
        else if (gradePercantage >= 70)
        {
            gradeLetter = 'C';
        }
        else if (gradePercantage >= 60)
        {
            gradeLetter = 'D';
        }
        else
        {
            gradeLetter = 'F';
        }

        if (gradePercantage % 10 >= 7 && gradeLetter != 'A' && gradeLetter != 'F')
        {
            gradeSign = "+";
        }
        else if (gradePercantage % 10 < 3 && gradeLetter != 'F')
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }

        Console.WriteLine($"Your grade is {gradeLetter}{gradeSign}.");

        if (gradePercantage >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass.");
        }
    }
}