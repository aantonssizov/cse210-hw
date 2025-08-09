class EternalGoal : Goal
{
    public override int RecordEvent()
    {
        return BonusPoints;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Title},{Description},{BonusPoints}";
    }

    public override string ToString()
    {
        return $"{Title} {Description}";
    }

    public static EternalGoal CreateEternalGoal(string stringRepresentation)
    {
        string[] properties = stringRepresentation.Split(',');

        EternalGoal eternalGoal = new()
        {
            Title = properties[0],
            Description = properties[1],
            BonusPoints = int.Parse(properties[2]),
        };

        return eternalGoal;
    }
}