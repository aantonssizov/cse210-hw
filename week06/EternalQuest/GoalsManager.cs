using System.Reflection;

class GoalsManager
{
    public int TotalPoints { get; set; }
    public List<Goal> Goals { get; set; } = [];

    public void Save()
    {
        Console.WriteLine("Enter the name of filename (*.txt): ");
        string filename = Console.ReadLine();

        using StreamWriter outputFile = new(filename, false);
        outputFile.WriteLine(TotalPoints);
        Goals.ForEach(goal =>
        {
            outputFile.WriteLine(goal.GetStringRepresentation());
        });
    }

    public void DoYouWantToSave()
    {
        Console.Write("Do you want to save first? (yes/no) ");
        string userChoice = Console.ReadLine().ToLower();

        if (userChoice == "yes")
            Save();
    }

    public void Load()
    {
        DoYouWantToSave();
        Console.WriteLine("Enter the name of filename (*.txt): ");
        string filename = Console.ReadLine();

        string fullPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" + filename;

        if (!File.Exists(fullPath))
        {
            Console.WriteLine("File not exists.");
            return;
        }

        string[] lines = File.ReadAllLines(fullPath);

        TotalPoints = int.Parse(lines[0]);
        Goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] lineParts = lines[i].Split(":");

            switch (lineParts[0])
            {
                case "SimpleGoal":
                    Goals.Add(SimpleGoal.CreateSimpleGoal(lineParts[1]));
                    break;
                case "EternalGoal":
                    Goals.Add(EternalGoal.CreateEternalGoal(lineParts[1]));
                    break;
                case "ChecklistGoal":
                    Goals.Add(ChecklistGoal.GreateChecklistGoal(lineParts[1]));
                    break;
                default:
                    continue;
            }
        }
    }

    public void Create()
    {
        Console.Write("What kind of goal do you want to create (s for Simple, e for Eternal, c for Checklist)");

        string kindOfGoal = Console.ReadLine();

        switch (kindOfGoal.ToLower())
        {
            case "s":
                CreateSimpleGoal();
                break;
            case "e":
                CreateEternalGoal();
                break;
            case "c":
                CreateChecklistGoal();
                break;
            default:
                break;
        }
    }

    private void CreateChecklistGoal()
    {
        Console.Write("Enter the title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the description: ");
        string description = Console.ReadLine();

        int bonusPoints;
        do
            Console.Write("Enter the amount of bonus points: ");
        while (!int.TryParse(Console.ReadLine(), out bonusPoints));

        int extraBonusPoints;
        do
            Console.Write("Enter the amount of extra bonus points: ");
        while (!int.TryParse(Console.ReadLine(), out extraBonusPoints));

        int timesToBeCompleted;
        do
            Console.Write("Enter the number of times to be completed: ");
        while (!int.TryParse(Console.ReadLine(), out timesToBeCompleted));


        ChecklistGoal checklistGoal = new()
        {
            Title = title,
            Description = description,
            BonusPoints = bonusPoints,
            ExtraBonusPoints = extraBonusPoints,
            TimesToBeCompleted = timesToBeCompleted
        };

        Goals.Add(checklistGoal);
        Console.WriteLine("Succesfully created a new goal!");
    }

    private void CreateEternalGoal()
    {
        Console.Write("Enter the title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the description: ");
        string description = Console.ReadLine();

        int bonusPoints;
        do
            Console.Write("Enter the amount of bonus points: ");
        while (!int.TryParse(Console.ReadLine(), out bonusPoints));

        EternalGoal eternalGoal = new()
        {
            Title = title,
            Description = description,
            BonusPoints = bonusPoints
        };

        Goals.Add(eternalGoal);
        Console.WriteLine("Succesfully created a new goal!");
    }

    private void CreateSimpleGoal()
    {
        Console.Write("Enter the title: ");
        string title = Console.ReadLine();

        Console.Write("Enter the description: ");
        string description = Console.ReadLine();

        int bonusPoints;
        do
            Console.Write("Enter the amount of bonus points: ");
        while (!int.TryParse(Console.ReadLine(), out bonusPoints));

        SimpleGoal simpleGoal = new()
        {
            Title = title,
            Description = description,
            BonusPoints = bonusPoints,
        };

        Goals.Add(simpleGoal);
        Console.WriteLine("Succesfully created a new goal!");
    }

    public void List()
    {
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Goals[i]}");
        }
    }

    public void Record()
    {
        List();

        Console.Write("For which goal do you want to record an event? ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index - 1 < 0 || index - 1 >= Goals.Count)
            return;

        TotalPoints += Goals[index - 1].RecordEvent();
        Console.WriteLine("Succesfully recorded an event");
    }
}