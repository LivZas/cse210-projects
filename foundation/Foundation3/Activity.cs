using System;

public abstract class Activity
{
    private DateTime _activityDate;
    private int _durationInMinutes;

    public Activity(DateTime activityDate, int durationInMinutes)
    {
        _activityDate = activityDate;
        _durationInMinutes = durationInMinutes;
    }

    protected DateTime ActivityDate => _activityDate;
    protected int DurationInMinutes => _durationInMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{ActivityDate:dd MMM yyyy} {this.GetType().Name} ({DurationInMinutes} min): Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
