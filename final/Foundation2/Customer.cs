public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name)
    {
        _name = name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
    public bool LiveInUSA()
    {
        return _address.isLivingInUSA();
    }
    public string GetCustomerString()
    {
        return $"{_name},\n{_address.GetAddress()}";
    }
}