public class OutdoorGatheringEvent : Event
{
    private double _weatherForecast;
    public OutdoorGatheringEvent(string title, string description, string date, string time, double weather) : base(title, description, date, time)
    {
        _weatherForecast = weather;
    }
    public string GetFullDetails()
    {
        return $"Outdoor Gathering Event, Weather: ${_weatherForecast}°F\n{GetStandardDetails()}";
    }
    public string GetShortDescription()
    {
        return $"Outdoor Gathering Event, {_title}, {_date}";
    }
}