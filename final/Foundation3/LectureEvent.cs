public class LectureEvent : Event
{
    private string _speakerName;
    private int _capacity;
    public LectureEvent(string title, string description, string date, string time, string speakerName, int capacity) : base(title, description, date, time)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
    public string GetShortDescription()
    {
        return $"Lecture Event, {_title}, {_date}";
    }
    public string GetFullDetails()
    {
        return $"Lecture Event, {_speakerName}, Capacity: ${_capacity}\n${GetStandardDetails()}";
    }

}