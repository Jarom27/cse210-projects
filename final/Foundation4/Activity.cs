public class Activity
{
    protected string _date;
    protected int _lengthActivity;
    public Activity(string date, int length)
    {
        _date = date;
        _lengthActivity = length;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return $"";
    }
}