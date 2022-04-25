namespace Crest.Entities
{
    public record Channel : IEntity<ulong>
    {
        public ulong Id { get; }

        public string Name { get; }

        public Channel()
        {

        }
    }
}
