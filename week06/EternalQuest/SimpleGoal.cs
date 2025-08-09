class SimpleGoal : Goal
{
    public bool Completed { get; private set; }

    public override int RecordEvent()
    {
        Completed = true;
        return BonusPoints;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Title},{Description},{BonusPoints},{Completed}";
    }

    public override string ToString()
    {
        return $"[{(Completed ? 'X' : ' ')}] {Title} {Description}";
    }

    public static SimpleGoal CreateSimpleGoal(string stringRepresentation)
    {
        string[] properties = stringRepresentation.Split(',');

        SimpleGoal simpleGoal = new()
        {
            Title = properties[0],
            Description = properties[1],
            BonusPoints = int.Parse(properties[2]),
            Completed = bool.Parse(properties[3])
        };

        return simpleGoal;
    }
}