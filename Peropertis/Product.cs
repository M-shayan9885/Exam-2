class Product
{
    public string? Name { get; set; }
    public int Price { get; set; }
    public DateTime DateTime { get; set; }

    public void GetProduct(string name,int price,DateTime dateTime)
    {
        Name = name;
        Price = price;
        DateTime = dateTime;
    }
}

