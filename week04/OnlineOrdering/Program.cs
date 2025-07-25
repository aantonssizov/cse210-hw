using System;

class Program
{
    static void Main(string[] args)
    {
        Customer USACustomer = new()
        {
            Name = "Laney",
            Address = new()
            {
                StreetAddress = "674 Malingway",
                City = "Las Vegas",
                State = "Nevada",
                Country = "USA"
            }
        };

        Customer EuropeCustomer = new()
        {
            Name = "Peter",
            Address = new()
            {
                StreetAddress = "str. Leopold 3",
                City = "London",
                State = "England",
                Country = "GB"
            }
        };

        Order order1 = new()
        {
            Customer = USACustomer,
            Products = [
                new() {
                    Name = "Music Box",
                    Price = 10,
                    ProductId = 23882,
                    Quantity = 1
                },
                new() {
                    Name = "Flute",
                    Price = 200,
                    ProductId = 24883,
                    Quantity = 2
                }
            ]
        };

        Order order2 = new()
        {
            Customer = EuropeCustomer,
            Products = [
                new () {
                    Name = "The Beatles CD",
                    Price = 15,
                    ProductId = 25009,
                    Quantity = 2
                },
                new() {
                    Name = "Queen CD",
                    Price = 17,
                    ProductId = 20993,
                    Quantity = 1
                }
            ]
        };

        Console.WriteLine(order1.PackingLabel);
        Console.WriteLine(order1.ShippingLabel);
        Console.WriteLine(order1.CalculateTotalPrice());

        Console.WriteLine();

        Console.WriteLine(order2.PackingLabel);
        Console.WriteLine(order2.ShippingLabel);
        Console.WriteLine(order2.CalculateTotalPrice());
    }
}