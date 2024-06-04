public class CyclingActivity : Activity
{
    private double _speed;
    public CyclingActivity(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * ((double)_lengthActivity / 60);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_lengthActivity} min) - Distance: {GetDistance():N1} miles, Speed: {GetSpeed():N1} mph, Pace: {GetPace():N1} min per mile";
    }
}