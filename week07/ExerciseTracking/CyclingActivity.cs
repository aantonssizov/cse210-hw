class CyclingActivity : Activity
{
    public double Speed { get; set; }

    public override double GetDistance() => Speed * Lenght / 60;

    public override double GetSpeed() => Speed;

    public override double GetPace() => 60 / Speed;
}