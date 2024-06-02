using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("201 Star Light Clime", "Canton", "GA", "USA");
        Customer customer1 = new Customer ("Pam Worsham", address1);

        List<Product> product = new List<Product>();

        Product product1 = new Product("Shirt", 10, 5, 2);
        Product product2 = new Product("Shoes", 12, 14, 1);
        Product product3 = new Product("Socks", 13, 3, 2);
        Product product4 = new Product("Tie", 14, 11, 1);

        product.Add(product1);
        product.Add(product2);
        product.Add(product3);
        product.Add(product4);

        Order order1 = new Order(product, customer1);
        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost {order1.CalculateTotalCost()}\n");

        Address address2 = new Address ("553 Daybreak", "Atlanta", "GA", "USA");
        Customer customer2 = new Customer ("Sue Smith", address2);

        List<Product> products = new List<Product>();

        Product product5 = new Product("Towel", 10, 5, 2);
        Product product6 = new Product("Wash cloth", 12, 14, 1);
       

        product.Add(product5);
        product.Add(product6);
       

        Order order2 = new Order(product, customer2);
        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost {order2.CalculateTotalCost()}");
    }

}