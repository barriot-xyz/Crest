using Model = Crest.Api.Json.UserModel;

namespace Crest.Entities
{
    public record GuildMember : User
    {
        public string Nickname { get; }

        public string GuildBannerId { get; }

        public string GuildAvatarId { get; }

        internal GuildMember(Model model) : base(model)
        {
            
        }

        public static bool TryParse(string json, out GuildMember entity)
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
            => $"<@{Id}>";
    }
}
