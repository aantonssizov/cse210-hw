using System.Timers;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Do()
    {
        int duration = _duration;
        while (duration > 0)
        {
            DisplayAnimations.CountdownMessage("Breathe in", 4);
            duration -= 4;

            DisplayAnimations.CountdownMessage("Breathe out", 4);
            duration -= 4;
        }
    }
}