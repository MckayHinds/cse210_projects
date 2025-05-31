public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    // int and bool (let's hope this works like how it should)
    public abstract int RecordEvent();
    public abstract bool isComplete();
    public virtual string GetDetailsString()
    {
        
    }
}