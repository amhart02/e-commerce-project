class Order
{
    private static int _orderCounter = 0;
    private int _orderID;
    private List<Product> _products;
    private double _totalCost;
    private string _orderDate;
    private int _userID;
    public Order(List<Product> products, double totalCost, string orderDate, int userID)
    {
        _orderID = ++_orderCounter;
        _products = products;
        _totalCost = totalCost;
        _orderDate = orderDate;
        _userID = userID;
    }
    public void DisplayOrder()
    {
        Console.WriteLine($"Order ID: {_orderID}");
        Console.WriteLine($"Date Ordered: {_orderDate}");
        Console.WriteLine($"User ID: {_userID}");
        Console.WriteLine($"Total Cost: {_totalCost:F2}");
        Console.WriteLine("Products Ordered:");
        foreach (Product product in _products)
        {
            product.OrderDisplayProduct();
        }
        Console.WriteLine();
    }
}