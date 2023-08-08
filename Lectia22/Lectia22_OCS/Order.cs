
// Clasa pentru gestionarea comenzilor
class Order
{
    public Product Product { get; set; }
    public decimal TotalPrice { get; set; }

    public void CalculateTotalPrice(DiscountCalculator discountCalculator)
    {
        TotalPrice = Product.Price - discountCalculator.CalculateDiscount(Product);
    }
}
