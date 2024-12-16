using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime activityDate, int durationInMinutes, double speed) 
        : base(activityDate, durationInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed * DurationInMinutes) / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}
