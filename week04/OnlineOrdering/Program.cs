using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - USA customer
        Address address1 = new Address("123 Maple St", "Austin", "Texas", "USA");
        Customer customer1 = new Customer("Sarah Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "P001", 15.99, 2));
        order1.AddProduct(new Product("Keyboard", "P002", 45.50, 1));
        order1.AddProduct(new Product("USB Cable", "P003", 5.99, 3));

        // Order 2 - non-USA customer
        Address address2 = new Address("45 Ahmadu Bello Way", "Abuja", "FCT", "Nigeria");
        Customer customer2 = new Customer("Chidi Okafor", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop Stand", "P004", 29.99, 1));
        order2.AddProduct(new Product("Webcam", "P005", 39.99, 1));

        Order[] orders = { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();

            Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
            Console.WriteLine(new string('-', 30));
        }
    }
}