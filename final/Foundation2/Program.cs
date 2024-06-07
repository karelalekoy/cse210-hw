using System;
using System.Net.Http.Headers;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("3123 Maple Street", "Springfield", "IL", "USA");
        Customer c1 = new Customer("John Doe", a1);
        List<Product> productList1 = new List<Product>();
        Product p1001 = new Product("Laptop", "LP123", 999.99, 10);
        Product p1002 = new Product("Notebook", "NB50", 3.50, 5);
        Product p1003 = new Product("Bluetooth Speaker", "BS404", 89.99, 40);
        productList1.Add(p1001);
        productList1.Add(p1002);
        productList1.Add(p1003);
        Order o1 = new Order(productList1, c1);
        Console.WriteLine("Order Number: 1");
        o1.DisplayResults();
        Console.WriteLine();
        Address a2 = new Address("456 Oak Avenue", "Lincoln", "NE", "USA");
        Customer c2 = new Customer("Susan Banks", a2);
        List<Product> productList2 = new List<Product>();
        Product p2001 = new Product("Highlighter Set", "HLSET", 4.99, 3);
        Product p2002 = new Product("Smartphone", "SP456", 499.99, 25);
        Product p2003 = new Product("Headphones", "HP789", 199.99, 50);
        productList2.Add(p2001);
        productList2.Add(p2002);
        productList2.Add(p2003);
        Order o2 = new Order(productList2, c2);
        Console.WriteLine("Order Number: 2");
        o2.DisplayResults();
        Console.WriteLine();
        Address a3 = new Address("789 Pine Road", "Portland", "OR", "USA");
        Customer c3 = new Customer("Timothy Smith", a3);
        List<Product> productList3 = new List<Product>();
        Product p3001 = new Product("Tablet", "TB101", 299.99, 15);
        Product p3002 = new Product("Wireless Mouse", "WM606", 29.99, 75);
        productList3.Add(p3001);
        productList3.Add(p3002);
        Order o3 = new Order(productList3, c3);
        Console.WriteLine("Order Number: 3");
        o3.DisplayResults();
        Console.WriteLine();

    }
}