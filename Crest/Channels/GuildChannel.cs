using Model = Crest.Api.Json.ChannelModel;

namespace Crest.Entities
{
    public record GuildChannel : Channel
    {
        internal GuildChannel(Model model) : base(model)
        {
            
        }

        public static bool TryParse(string json, out GuildChannel entity)
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
