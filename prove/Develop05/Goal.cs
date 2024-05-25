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
    public string GetShortName()
    {
        return _shortName;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public virtual string GetStringDetails()
    {
        string details = "[";
        if (IsComplete())
        {
            details += "X]";
        }
        else
        {
            details += " ]";
        }
        details += $" {_shortName} ({_description})";
        return details;
    }


}