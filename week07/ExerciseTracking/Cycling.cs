public class Cycling : Activity
{
    private double _speed;
    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }
    //Math portion - using "goes to" lambda operator
    public override double GetSpeed() => _speed;
    public override double GetDistance() => (_speed * Minutes) / 60;
    public override double GetPace() => 60 / _speed;
}