using Model = Crest.Models.Guild;

namespace Crest
{
    public record Guild : IGuild
    {
        public IClient Client { get; }

        public ulong Id { get; }

        public string? Name { get; }

        internal Guild(Model model, IClient client)
        {
            Client = client;

            Id = model.Id;
            Name = model.Name;
        }

        public static bool TryParse(DiscordClient client, string json, out Guild entity)
        {
            var model = JsonConvert.DeserializeObject<Model>(json);

            if (model is not null)
            {
                entity = new(model, client);
                return true;
            }
            else
            {
                entity = null!;
                return false;
            }
        }
    }
}
