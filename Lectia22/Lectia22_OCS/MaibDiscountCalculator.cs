namespace Lectia22_OCS
{
    internal class MaibDiscountCalculator : DiscountCalculator
    {
        public override decimal CalculateDiscount(Product product)
        {
            return product.Price * 0.1m;
        }
    }
}
