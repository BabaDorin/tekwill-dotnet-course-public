using Lectia20_1.Entities;

namespace Lectia20_1
{
    internal class Database<T> : IDatabase<T>
        where T : IEntity
    {
        private readonly List<T> _items;

        public Database()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Delete(Guid id)
        {
            var toRemove = _items.FirstOrDefault(item => item.Id == id);

            if (toRemove is not null)
            {
                _items.Remove(toRemove);
            }
        }

        public T Get(Guid id)
        {
            var foundItem = _items.FirstOrDefault(item => item.Id == id);

            return foundItem;
        }

        public void Update(T item)
        {
            var toUpdate = _items.FirstOrDefault(element => element.Id == item.Id);

            if (toUpdate is not null)
            {
                _items.Remove(toUpdate);
                _items.Add(item);
            }
            else
            {
                throw new Exception("Product not found.");
            }
        }
    }
}
