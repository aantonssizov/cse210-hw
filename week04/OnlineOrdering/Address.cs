class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public bool IsInUSA => Country == "USA";
    public string FullAddress => $"{StreetAddress}, {City}, {State}, {Country}";

    public override string ToString()
    {
        return FullAddress;
    }
}