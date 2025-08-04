
class ListingActivity : Activity
{
    private readonly List<string> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Do()
    {
        bool timerElapsed = false;
        System.Timers.Timer _timer = new(_duration * 1000)
        {
            AutoReset = false,
            Enabled = true
        };
        _timer.Elapsed += (o, e) =>
        {
            timerElapsed = true;
        };

        string prompt = SelectRandomPrompt();
        DisplayAnimations.CountdownMessage(prompt);

        List<string> listings = [];

        while (!timerElapsed)
        {
            listings.Add(Console.ReadLine());
        }

        Console.WriteLine($"Total listed: {listings.Count}");
    }

    private string SelectRandomPrompt()
    {
        Random random = new();
        int randomIndex = random.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];

        _prompts.Remove(prompt);

        return prompt;
    }
}