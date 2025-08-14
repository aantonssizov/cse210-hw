using System.Runtime;

abstract class Activity
{
    public DateTime Date { get; set; }
    public int Lenght { get; set; }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary() => $"{Date.ToShortDateString()} ({Lenght}min): Distance {GetDistance():#0.##} km, Speed: {GetSpeed():#0.##} km/h, Pace: {GetPace():#0.##} min per km";
}