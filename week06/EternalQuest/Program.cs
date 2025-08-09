using System;

class Program
{
    static void Main(string[] args)
    {
        GoalsManager goalsManager = new();

        Console.WriteLine("Welcome to Eternal Quest program!");

        while (true)
        {
            Console.WriteLine(goalsManager.TotalPoints);
            Console.WriteLine("1. Create");
            Console.WriteLine("2. List");
            Console.WriteLine("3. Record");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Quit");

            Console.Write("Choose your option: ");

            if (!int.TryParse(Console.ReadLine(), out int userChoice))
                continue;

            if (userChoice == 1)
                goalsManager.Create();
            else if (userChoice == 2)
                goalsManager.List();
            else if (userChoice == 3)
                goalsManager.Record();
            else if (userChoice == 4)
                goalsManager.Load();
            else if (userChoice == 5)
                goalsManager.Save();
            else if (userChoice == 6)
            {
                goalsManager.DoYouWantToSave();
                break;
            }
            else
                continue;
        }
    }
}