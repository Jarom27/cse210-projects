public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public Address()
    {
        _street = "";
        _city = "";
        _state = "";
        _country = "";
    }
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public string GetStreet()
    {
        return _street;
    }
    public void SetStreet(string street)
    {
        _street = street;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetState()
    {
        return _state;
    }
    public void SetState(string state)
    {
        _state = state;
    }
    public string GetCountry()
    {
        return _city;
    }
    public void SetCountry(string city)
    {
        _city = city;
    }
    public bool isLivingInUSA()
    {
        if (_country == "USA" || _country == "United States" || _country == "US")
            return true;

        return false;
    }
    public string GetAddress()
    {
        return $"{_street}, {_city}\n{_state}, {_country}";
    }

}