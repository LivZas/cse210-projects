using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime activityDate, int durationInMinutes, double distance) 
        : base(activityDate, durationInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (GetDistance() / DurationInMinutes) * 60;

    public override double GetPace() => DurationInMinutes / GetDistance();
}
