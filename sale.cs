class Sale : Product
{
    private double _discount;
    private string _saleEndDate;
    private int _stock;
    public Sale(string name, double price, string description, string category, double discount, string saleEndDate, int stock) : base(name, price, description, category)
    {
        _discount = discount;
        _saleEndDate = saleEndDate;
        _stock = stock;
    }
    public override void DisplayProduct(int productNumber)
    {
        base.DisplayProduct(productNumber);
        Console.WriteLine($"Discount Price: ${_discount}");
        Console.WriteLine($"Sale End Date: {_saleEndDate}");
        Console.WriteLine($"Stock Left: {_stock}");
    }
    public override void DisplayProductCart(int productNumber)
    {
        base.DisplayProductCart(productNumber);
        Console.WriteLine($"Sale End Date: {_saleEndDate}");
    }
}
