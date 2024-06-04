
public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address();
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
    public string GetAddress()
    {
        return _address.GetAddress();
    }
    public string GetStandardDetails()
    {
        return $"{_title}, \n{_description},\n{_date}, {_time}, \n{GetAddress()}";
    }
}