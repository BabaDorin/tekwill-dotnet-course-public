using Lectia20_1.Entities;

namespace Lectia20_1
{
    internal interface IDatabase<T>
        where T : IEntity
    {
        void Add(T item);

        void Delete(Guid id);

        T Get(Guid id);

        void Update(T item);
    }
}
