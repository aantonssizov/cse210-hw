class ChecklistGoal : Goal
{
    public int TimesCompleted { get; set; }
    public int TimesToBeCompleted { get; set; }
    public int ExtraBonusPoints { get; set; }

    public override int RecordEvent()
    {
        if (TimesCompleted == TimesToBeCompleted)
            return 0;

        if (++TimesCompleted == TimesToBeCompleted)
            return BonusPoints + ExtraBonusPoints;

        return BonusPoints;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoals:{Title},{Description},{BonusPoints},{ExtraBonusPoints},{TimesCompleted},{TimesToBeCompleted}";
    }

    public override string ToString()
    {
        return $"[{(TimesCompleted == TimesToBeCompleted ? 'X' : ' ')}] {Title} {Description} (Completed {TimesCompleted}/{TimesToBeCompleted} times)";
    }

    public static ChecklistGoal GreateChecklistGoal(string stringRepresentation)
    {
        string[] properties = stringRepresentation.Split(',');

        ChecklistGoal checklistGoal = new()
        {
            Title = properties[0],
            Description = properties[1],
            BonusPoints = int.Parse(properties[2]),
            ExtraBonusPoints = int.Parse(properties[3]),
            TimesCompleted = int.Parse(properties[4]),
            TimesToBeCompleted = int.Parse(properties[5])
        };

        return checklistGoal;
    }
}