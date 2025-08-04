using System.Transactions;

abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration; // in seconds
    private DateTime _startTime;
    private DateTime _endTime;

    public void Begin()
    {
        Console.Clear();
        Console.WriteLine($"Prepare for {_name}.\n");
        Console.WriteLine(_description);

        Console.Write("For how long would you like to do this activity? (in seconds) ");
        _duration = int.Parse(Console.ReadLine());

        DisplayAnimations.CountdownMessage("\nPrepare for a couple of seconds");

        Console.WriteLine("Ready? Let's start!");
        _startTime = DateTime.Now;
    }

    public abstract void Do();

    public void Finish()
    {
        _endTime = DateTime.Now;

        Console.WriteLine("Thank you! You did an awesome job! Celebrate it!");
        DisplayAnimations.Spinner(3);

        TimeSpan timeTaken = _endTime.Subtract(_startTime);
        Console.WriteLine($"{_name} took {timeTaken.TotalSeconds}s.");
        DisplayAnimations.Spinner(5);
    }
}