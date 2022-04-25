namespace Crest.Entities
{
    public record Thread : IEntity<ulong>
    {
        public Thread()
        {

        }

        public ulong Id { get; }
    }
}
