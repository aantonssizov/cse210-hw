using System.Reflection;

class Journal
{
    public List<Entry> Entries { get; set; }

    public bool IsSaved { get; private set; }

    public Journal()
    {
        Entries = [];
        IsSaved = false;
    }

    public void AddNewEntry()
    {
        string prompt = PromptGenerator.GetRandomPrompt();

        Console.WriteLine(prompt);
        string content = Console.ReadLine();

        DateTime date = DateTime.Now;

        Entry newEntry = new()
        {
            Date = date,
            Prompt = prompt,
            Content = content
        };

        Entries.Add(newEntry);
        IsSaved = false;
    }

    public void Display()
    {
        Entries.ForEach((entry) =>
        {
            Console.WriteLine($"{entry.Date} - {entry.Prompt}");
            Console.WriteLine(entry.Content);
            Console.WriteLine();
        });
    }

    public void Save()
    {
        Console.Write("Type in the name of your journal file (including extension): ");
        string filename = Console.ReadLine();

        using StreamWriter outputFile = new(filename, false);
        Entries.ForEach((entry) =>
        {
            outputFile.WriteLine($"{entry.Date} - {entry.Prompt}");
            outputFile.WriteLine(entry.Content);
            outputFile.WriteLine();
        });

        IsSaved = true;
    }

    public void Load()
    {
        Console.Write("Type in the name of your journal file (including extension): ");
        string filename = Console.ReadLine();

        string fullPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" + filename;

        if (!File.Exists(fullPath))
        {
            Console.WriteLine("File not exists.");
            return;
        }

        string[] lines = File.ReadAllLines(fullPath);

        Entry entry;
        int i = 0;
        while (i < lines.Length)
        {
            // First line of an entry
            string line = lines[i];
            entry = new();

            string[] parts = line.Split(" - ");

            entry.Date = DateTime.Parse(parts[0]);
            entry.Prompt = parts[1];

            // Second line of an entry
            line = lines[++i];
            entry.Content = line;

            // Third line of an entry
            i += 2;
            Entries.Add(entry);
        }
    }
}