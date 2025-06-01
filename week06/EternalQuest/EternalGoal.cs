public class EternalGoal : Goal //Problem Child
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool isComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"EternalGoal: {_shortName}, {_description}, {_points}";
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {_shortName}, {_description}, {_points}";
    }
}