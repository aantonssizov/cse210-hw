class Program
{
    static void Main(string[] args)
    {
        string currentDate = DateTime.Now.ToShortDateString();
        Console.WriteLine($"Welcome to the Jornal App. Today is {currentDate}. You can do the following: ");

        Journal journal = new();

        while (true)
        {
            PrintMenu();

            int userChoice = GetUserChoice();

            if (userChoice == 1)
            {
                journal.AddNewEntry();
            }
            else if (userChoice == 2)
            {
                journal.Display();
            }
            else if (userChoice == 3)
            {
                journal.Load();
            }
            else if (userChoice == 4)
            {
                journal.Save();
            }
            else if (userChoice == 5)
            {
                QuitProgram(journal);
                break;
            }
            else
            {
                continue;
            }
        }
    }

    private static void QuitProgram(Journal journal)
    {
        if (journal.Entries.Count > 0 && !journal.IsSaved)
        {
            Console.Write("Your journal is not saved, do you want to save it? (yes/no) ");
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                journal.Save();
            }
        }

        Console.WriteLine("Good job keeping your journal today! See you tomorrow!");
    }

    private static int GetUserChoice()
    {
        Console.Write("What would you like to do? ");

        bool conversionSuccessful = int.TryParse(Console.ReadLine(), out int userChoice);

        if (!conversionSuccessful)
        {
            userChoice = 0;
        }

        return userChoice;
    }

    private static void PrintMenu()
    {
        string[] menuOptions = ["Add New Entry", "Display", "Load", "Save", "Quit"];

        for (int i = 0; i < menuOptions.Length; i++)
        {
            string menuOption = menuOptions[i];
            int index = i + 1;

            Console.WriteLine($"{index}. {menuOption}");
        }
    }
}