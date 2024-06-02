using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product(233, "Laptop Dell", 123.99);
        product1.SetQuantity(1);
        Product product2 = new Product(341, "Xbox One", 199.99);
        product2.SetQuantity(2);

        Customer customer1 = new Customer("Jarom Mariscal");
        customer1.SetAddress(new Address("Paseo del Torreon", "Obregon City", "Sonora", "Mexico"));
        Order order1 = new Order();
        order1.SetCustomer(customer1);
        order1.AddProducts(product1);
        order1.AddProducts(product2);
        order1.GetShippingLabel();
        order1.GetPackingLabel();
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        Product product3 = new Product(233, "Iphone 18", 999.99);
        product3.SetQuantity(1);
        Product product4 = new Product(341, "Playstation", 234.99);
        product4.SetQuantity(4);

        Customer customer2 = new Customer("Jacob Smith");
        customer2.SetAddress(new Address("40 West", "Rexburgh", "Idaho", "USA"));
        Order order2 = new Order();
        order2.SetCustomer(customer2);
        order2.AddProducts(product3);
        order2.AddProducts(product4);
        order2.GetShippingLabel();
        order2.GetPackingLabel();
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}