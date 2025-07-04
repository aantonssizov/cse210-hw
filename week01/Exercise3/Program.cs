using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        int guess;
        int attempts;
        string keepPlaying = "yes";

        while (keepPlaying == "yes")
        {
            magicNumber = new Random().Next(1, 101);
            attempts = 0;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it! It took " + attempts + " attempts.");
                    Console.Write("Do you want to play again? (yes/no) ");
                    keepPlaying = Console.ReadLine().ToLower();
                }
            } while (guess != magicNumber);
        }
    }
}