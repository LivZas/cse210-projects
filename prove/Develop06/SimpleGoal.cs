public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points, isComplete)
    {
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return IsComplete() ? $"{_shortName}: {_description} [Completed]" : $"{_shortName}: {_description} [Not completed]";
    }

    public override string GetStringRepresentation()
    {
        return IsComplete() ? $"[X] {_shortName} ({_description})" : $"[ ] {_shortName} ({_description})";
    }

    public override string GetStringRepresentationForSaving()
    {
        return $"SimpleGoal,{_shortName},{_description},{_points},{_isComplete}";
    }
}
