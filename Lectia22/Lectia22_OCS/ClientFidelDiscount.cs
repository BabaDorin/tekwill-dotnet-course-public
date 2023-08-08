namespace Lectia22_OCS
{
    internal class ClientFidelDiscount : DiscountCalculator
    {
        public override decimal CalculateDiscount(Product product)
        {
            return product.Price * 0.5m;
        }
    }
}
