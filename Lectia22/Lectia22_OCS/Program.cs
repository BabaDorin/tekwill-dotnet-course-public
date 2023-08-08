using Lectia22_OCS;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product { Name = "Laptop", Price = 1000 };
        
        MaibDiscountCalculator discountCalculator = new MaibDiscountCalculator();
        
        Order order = new Order { Product = product };

        var clientFidelDiscount = new ClientFidelDiscount();

        order.CalculateTotalPrice(clientFidelDiscount);

        Console.WriteLine($"Total price after discount: ${order.TotalPrice}");
    }
}
