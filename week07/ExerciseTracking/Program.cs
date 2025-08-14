using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = [
            new RunningActivity() {
                Date = DateTime.Now,
                Lenght = 30,
                Distance = 5
            },
            new CyclingActivity() {
                Date = DateTime.Now,
                Lenght = 30,
                Speed = 14
            },
            new SwimmingActivity() {
                Date = DateTime.Now,
                Lenght = 10,
                Laps = 20
            }
        ];

        activities.ForEach(activity => Console.WriteLine(activity.GetSummary()));
    }
}