using System.Diagnostics.CodeAnalysis;

class Product
{
    private string _name;
    private double _price;
    private string _description;
    private string _category;
    public Product(string name, double price, string description, string category)
    {
        _name = name;
        _price = price;
        _description = description;
        _category = category;
    }
    public virtual void DisplayProduct(int productNumber)
    {
        Console.WriteLine($"{productNumber}. {_name}");
        Console.WriteLine("----------------------");
        Console.WriteLine($"Category: {_category}");
        Console.WriteLine($"${_price}");
        Console.WriteLine(_description);
    }
    public double GetPrice()
    {
        return _price;
    }
    public virtual void DisplayProductCart(int productNumber)
    {
        Console.WriteLine($"{productNumber}: {_name} - ${_price}");
    }
    public string GetName()
    {
        return _name;
    }
    public void OrderDisplayProduct()
    {
        Console.WriteLine($"{_name} - {_price}");
    }
}