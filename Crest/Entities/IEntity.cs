namespace Crest.Entities
{
    public interface IEntity<out TId>
    {
        /// <summary>
        ///     Represents the ID of this resource.
        /// </summary>
        public TId Id { get; }
    }
}
