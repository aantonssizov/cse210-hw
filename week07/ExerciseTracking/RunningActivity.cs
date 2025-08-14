class RunningActivity : Activity
{
    public double Distance { get; set; }

    public override double GetDistance() => Distance;

    public override double GetSpeed() => Distance / Lenght * 60;

    public override double GetPace() => 60 / GetSpeed();

}