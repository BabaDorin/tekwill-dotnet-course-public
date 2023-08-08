enum ProductType
{
    Widget,

}

class Order
{
    public int OrderId { get; set; }
    public string Product { get; set; }

    public int Quantity { get; set; }
}

class Program
{
    static void Main()
    {
        var orders = new List<Order>
        {
            new Order { OrderId = 1, Product = "Widget", Quantity = 3 },
            new Order { OrderId = 2, Product = "Gadget", Quantity = 2 },
            new Order { OrderId = 3, Product = "Widget", Quantity = 5 },
            new Order { OrderId = 4, Product = "Gadget", Quantity = 4 }
        };

        var productGroups = orders.GroupBy(order => order.Product);

        var group1 = productGroups.First();
    }
}
