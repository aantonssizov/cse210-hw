class Product
{
    public string Name { get; set; }
    public int ProductId { get; init; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public int TotalCost => Price * Quantity;
}