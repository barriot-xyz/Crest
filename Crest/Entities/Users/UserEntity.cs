namespace Crest.Entities
{
    public record UserEntity : IEntity
    {
        public UserEntity()
        {

        }

        public ulong Id { get; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
