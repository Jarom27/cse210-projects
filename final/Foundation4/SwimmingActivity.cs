public class SwimmingActivity : Activity
{
    private const int LAP = 50;
    private int _numberOfLaps;
    public SwimmingActivity(string date, int length, int numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }
    public override double GetDistance()
    {
        return (double)_numberOfLaps * LAP / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return GetDistance() / _lengthActivity * 60;
    }
    public override double GetPace()
    {
        return 60 * GetSpeed();
    }
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_lengthActivity} min) - Distance: {GetDistance():N1} miles, Speed: {GetSpeed():N1} mph, Pace: {GetPace():N1} min per mile";
    }
}