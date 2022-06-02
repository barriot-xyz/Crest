using Model = Crest.Api.Json.ChannelModel;

namespace Crest.Entities
{
    public record Channel : IEntity<ulong>
    {
        public ulong Id { get; }

        public string Name { get; }

        internal Channel(Model model) 
        {
            Id = model.Id;
        }

        public static bool TryParse(string json, out Channel entity)
        {
            var model = JsonConvert.DeserializeObject<Model>(json);

            if (model is not null)
            {
                entity = new(model);
                return true;
            }
            else
            {
                entity = null!;
                return false;
            }
        }

        public override string ToString()
            => $"<#{Id}>";
    }
}
