class Subscription : Product
{
    private string _subscriptionDuration;
    private double _renewalPrice;
    public Subscription(string name, double price, string description, string category, string subscriptionDuration, double renewalPrice) : base(name, price, description, category)
    {
        _subscriptionDuration = subscriptionDuration;
        _renewalPrice = renewalPrice;
    }
    public override void DisplayProduct(int productNumber)
    {
        base.DisplayProduct(productNumber);
        Console.WriteLine($"Subscription Duration: {_subscriptionDuration}");
        Console.WriteLine($"Renewal Price: ${_renewalPrice}");
    }
    public override void DisplayProductCart(int productNumber)
    {
        Console.WriteLine($"{productNumber}: {GetName()} - ${GetPrice()}/{_subscriptionDuration}");
    }
}