public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points, isComplete)
    {
    }

    public override void RecordEvent() { }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Eternal Goal)";
    }

    public override string GetStringRepresentation()
    {
        return IsComplete() ? $"[X] {_shortName} ({_description})" : $"[ ] {_shortName} ({_description})";
    }

    public override string GetStringRepresentationForSaving()
    {
        return $"EternalGoal,{_shortName},{_description},{_points},{_isComplete}";
    }
}
