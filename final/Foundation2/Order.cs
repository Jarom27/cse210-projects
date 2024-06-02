public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order()
    {
        _products = new List<Product>();
    }
    public void AddProducts(Product product)
    {
        _products.Add(product);
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        totalCost += _customer.LiveInUSA() ? 5 : 35;
        return totalCost;
    }
    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetId()} {product.GetName()}");
        }
    }
    public void GetShippingLabel()
    {
        Console.WriteLine(_customer.GetCustomerString());
    }

}