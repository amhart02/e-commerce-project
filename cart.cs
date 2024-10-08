using System.Runtime.CompilerServices;

class Cart
{
    private List<Product> _products;
    private double _totalCost;
    public Cart(double totalCost)
    {
        _products = new List<Product>();
        _totalCost = totalCost;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
        _totalCost += product.GetPrice();
    }
    public void DeleteProduct(Product product)
    {
        _products.Remove(product);
        _totalCost -= product.GetPrice();
    }
    public void DisplayCart()
    {
        int productNumber = 1;
        Console.WriteLine("Your Cart: ");
        if (_products.Count == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Your cart is empty.");
        }
        else
        {
            Console.WriteLine();
            foreach (Product product in _products)
            {
                product.DisplayProductCart(productNumber);
                productNumber += 1;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${_totalCost:F2}");
        Console.WriteLine();
    }
    public List<Product> GetListProducts()
    {
        return new List<Product>(_products);
    }
    public double GetTotalCost()
    {
        return _totalCost;
    }
    public void ClearCart()
    {
        _products.Clear();
        _totalCost = 0;
    }
}