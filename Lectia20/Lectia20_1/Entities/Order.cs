namespace Lectia20_1.Entities
{
    internal class Order : IEntity
    {
        public Guid Id { get; set; } 

        public DateTime CreatedAt { get; set; }

        public string Address { get; set; }
    }
}
