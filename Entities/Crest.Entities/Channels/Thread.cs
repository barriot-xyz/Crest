using Model = Crest.Models.Thread;

namespace Crest
{
    public record Thread : IChannel
    {
        public IClient Client { get; }

        public ulong Id { get; }

        public string Name { get; }

        internal Thread(Model model)
        {
            Id = model.Id;
        }

        public static bool TryParse(string json, out Thread entity)
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
            => Name;
    }
}
