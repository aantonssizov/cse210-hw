class Order
{
    public Customer Customer { get; set; }
    public List<Product> Products { get; set; }

    public string PackingLabel => string.Join(", ", Products.Select(product => $"{product.Name} {product.ProductId}"));

    public string ShippingLabel => $"{Customer.Name} {Customer.Address}";

    public int CalculateTotalPrice()
    {
        int totatlCost = Products.Select(product => product.TotalCost).Sum();

        if (Customer.IsInUSA)
        {
            return totatlCost + 5;
        }

        return totatlCost + 35;
    }
}