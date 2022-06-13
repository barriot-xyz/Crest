namespace Crest
{
    internal interface IEntity<TId>
    {
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

            var model = CrestConfiguration.Serializer.Deserialize<TModel>(jsonReader);

            if (model is not null)
            {
                result = model;
                return true;
            }
            return false;
        }
    }
}
