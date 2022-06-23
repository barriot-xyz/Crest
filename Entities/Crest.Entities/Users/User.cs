

namespace Crest
{
    public record User : PartialUser
    {
        public string? Username { get; }

        public string? Discriminator { get; }

        public string? AvatarId { get; }

        public string? BannerId { get; }

        public string? Locale { get; }

        public Color AccentColor { get; }

        public UserProperties PublicFlags { get; }

        public PremiumType PremiumType { get; }

        public bool IsBot { get; }

        internal User(Models.User model, DiscordClient client) : base(model, client)
        {
            IsBot = model.Bot ?? false;

            PremiumType = model.PremiumType.HasValue 
                ? model.PremiumType.Value 
                : PremiumType.None;

            Discriminator = model.Discriminator;
            AvatarId = model.Avatar;
            BannerId = model.Banner;
            AccentColor = Color.FromRawValue(model.AccentColor ?? 0);
            PublicFlags = model.PublicFlags ?? UserProperties.None;
            Locale = model.Locale;
        }

        internal static bool TryParse(DiscordClient client, string json, out User entity)
        {
            var model = JsonConvert.DeserializeObject<Models.User>(json);

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

        public override string ToString()
            => $"<@{Id}>";
    }
}
