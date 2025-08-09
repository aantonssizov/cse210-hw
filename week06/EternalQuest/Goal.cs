abstract class Goal
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int BonusPoints { get; set; }

    abstract public int RecordEvent();
    abstract public string GetStringRepresentation();
}