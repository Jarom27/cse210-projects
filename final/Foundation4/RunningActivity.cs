public class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / _lengthActivity * 60;
    }
    public override double GetPace()
    {
        return _lengthActivity / _distance;
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_lengthActivity} min) - Distance: {_distance:N1} miles, Speed: {GetSpeed():N1} mph, Pace: {GetPace():N1} min per mile";
    }


}