namespace Lectia17_1
{
    public interface IDatabaseProvider
    {
        public void Add(Order order);

        public Order Get(int id);

        public void Delete(int id);
    }
}
