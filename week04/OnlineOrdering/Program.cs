class Program
{
    static void Main()
    {
        var address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        var customer1 = new Customer("Emily Davis", address1);
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "N123", 4.99, 3));
        order1.AddProduct(new Product("Pen", "P456", 1.25, 5));

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        var address2 = new Address("789 Maple Rd", "Toronto", "ON", "Canada");
        var customer2 = new Customer("John Smith", address2);
        var order2 = new Order(customer2);
        order2.AddProduct(new Product("USB Drive", "U789", 15.00, 2));
        order2.AddProduct(new Product("Mouse", "M234", 20.00, 1));

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}
