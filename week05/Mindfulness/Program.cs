// Requirements exceeded: Make sure no random prompts/questions are selected until they have all been used at least once in that session.

using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new();
        ReflectionActivity reflectionActivity = new();
        ListingActivity listingActivity = new();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Midnfulness app!\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("\nChoose from the menu (1-4): ");
            if (!int.TryParse(Console.ReadLine(), out int userChoice)) continue;

            if (userChoice == 1)
            {
                breathingActivity.Begin();
                breathingActivity.Do();
                breathingActivity.Finish();
            }
            else if (userChoice == 2)
            {
                reflectionActivity.Begin();
                reflectionActivity.Do();
                reflectionActivity.Finish();
            }
            else if (userChoice == 3)
            {
                listingActivity.Begin();
                listingActivity.Do();
                listingActivity.Finish();
            }
            else if (userChoice == 4)
            {
                Console.WriteLine("Thank you for using our programm! Have a nice day!");
                break;
            }
        }
    }
}