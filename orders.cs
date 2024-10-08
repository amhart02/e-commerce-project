class Orders
{
    private List<Order> _orders;
    public Orders()
    {
        _orders = new List<Order>();
    }
    public void AddOrder(Order order)
    {
        _orders.Add(order);
    }
    public void DisplayOrders()
    {
        foreach (Order order in _orders)
        {
            order.DisplayOrder();
        }
    }
}