namespace Lectia17_1
{
    public class OrderManager
    {
        private readonly IDatabaseProvider _databaseProvider;

        public OrderManager(IDatabaseProvider databaseProvider)
        {
            _databaseProvider = databaseProvider;
        }

        public void AddOrder()
        {
            var order = new Order();
            order.Id = (int)DateTime.UnixEpoch.Ticks;

            _databaseProvider.Add(order);
        }

        public void DeleteOrder(int id)
        {
            var orderToDelete = _databaseProvider.Get(id);

            if (orderToDelete is null)
            {
                throw new Exception("Order with such id was not found");
            }

            _databaseProvider.Delete(id);
        }
    }
}
