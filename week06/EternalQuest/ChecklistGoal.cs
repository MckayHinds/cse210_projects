public class ChecklistGoal : Goal
{
    private int _ammountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _ammountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override int RecordEvent()
    {
        _ammountCompleted++;
        if (_ammountCompleted == _target)
        {
            return _points + _bonus;
        }
        return _points;
    }
    public override bool isComplete()
    {

    }
    public override string GetDetailsString()
    {

    }
    public override string GetStringRepresentation()
    {
        
    }
}