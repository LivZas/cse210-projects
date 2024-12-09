using System;

class Program
{
    static void Main()
    {
        Product product1 = new Product("Table", "P013459", 100.00, 1);
        Product product2 = new Product("Chair", "P345798", 50.50, 3);

        Address address1 = new Address("Mx", "Monterrey", "Mexico", "Mexico");
        Customer customer1 = new Customer("Luis Flores", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.TotalCost():F2}\n");

        Product product3 = new Product("Headphones", "P45456", 80.00, 1);
        Product product4 = new Product("Microwave", "P65743", 150.00, 1);
        Product product5 = new Product("Backpack", "P50067", 40.00, 1);

        Address address2 = new Address("12 Beach Rd", "Sydney", "NSW", "Australia");
        Customer customer2 = new Customer("Marcos Johnson", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.TotalCost():F2}\n");
    }
}
