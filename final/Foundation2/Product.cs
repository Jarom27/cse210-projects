using System.Dynamic;

public class Product
{
    private int _id;
    private string _name;
    private int _quantity;
    private double _price;
    public Product(int id, string name, double price)
    {
        _id = id;
        _name = name;
        _quantity = 0;
        _price = price;
    }
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
    public int GetId()
    {
        return _id;
    }
    public void SetId(int id)
    {
        _id = id;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public double GetPrice()
    {
        return _price;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
}