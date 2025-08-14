class SwimmingActivity : Activity
{
    public int Laps { get; set; }

    public override double GetDistance() => Laps * 50 / 1000;

    public override double GetSpeed() => GetDistance() / Lenght * 60;

    public override double GetPace() => Lenght / GetDistance();
}