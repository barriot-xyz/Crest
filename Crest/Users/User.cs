using Crest.Api;
using Crest.Api.Endpoints;
using Crest.Users.Properties;

namespace Crest.Users
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

        internal User(Models.User model) : base(model)
        {
            IsBot = model.Bot ?? false;

            PremiumType = model.PremiumType.HasValue 
                ? model.PremiumType.Value 
                : PremiumType.None;

            if (model.Discriminator.IsSpecified)
                Discriminator = model.Discriminator.Value;

            if (model.Avatar.IsSpecified)
                AvatarId = model.Avatar.Value;

            if (model.Banner.IsSpecified)
                BannerId = model.Banner.Value;

            if (model.AccentColor.IsSpecified)
                AccentColor = Color.FromRawValue(model.AccentColor.Value ?? 0);

            if (model.PublicFlags.IsSpecified)
                PublicFlags = model.PublicFlags.Value;

            if (model.Locale.IsSpecified)
                Locale = model.Locale.Value;
        }

        internal static bool TryParse(UserEndpoint client, string json, out User entity)
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

        public override string ToString()
            => $"<@{Id}>";
    }
}
