
// Clasa pentru calcularea reducerilor
class DiscountCalculator
{
    public virtual decimal CalculateDiscount(Product product)
    {
        return product.Price * 0.1M; // Reducere de 10%
    }
}
