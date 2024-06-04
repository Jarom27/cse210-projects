public class ReceptionEvent : Event
{
    private string _emailForRSVP;
    public ReceptionEvent(string title, string description, string date, string time, string emailForRSVP) : base(title, description, date, time)
    {
        _emailForRSVP = emailForRSVP;
    }
    public string GetFullDetails()
    {
        return $"Reception Event, ${_emailForRSVP}\n{GetStandardDetails()}";
    }
    public string GetShortDescription()
    {
        return $"Reception Event, {_title}, {_date}";
    }
}