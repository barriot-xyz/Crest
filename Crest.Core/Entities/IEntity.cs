namespace Crest
{
    /// <summary>
    ///     A Discord entity.
    /// </summary>
    /// <typeparam name="TId"></typeparam>
    public interface IEntity<TId>
    {
        /// <summary>
        ///     Holds the client reference that interacts with the resource.
        /// </summary>
        public IClient Client { get; }

        /// <summary>
        ///     Represents the ID of this resource.
        /// </summary>
        public TId Id { get; }

        /// <summary>
        ///     Parses the underlying model into an entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryParse<TModel>(string json, out TModel result)
        {
            result = default!;

            using var textReader = new StringReader(json);
            using var jsonReader = new JsonTextReader(textReader);

            var model = ClientConfiguration.Serializer.Deserialize<TModel>(jsonReader);

            if (model is not null)
            {
                result = model;
                return true;
            }
            return false;
        }
    }
}
