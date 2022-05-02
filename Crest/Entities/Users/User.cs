using Crest.Entities.Users.Properties;
using Model = Crest.Entities.Users.Models.UserModel;

namespace Crest.Entities
{
    public record User : IEntity<ulong>
    {
        public ulong Id { get; }

        public string? Username { get; }

        public string? Discriminator { get; }

        public string? AvatarId { get; }

        public string? BannerId { get; }

        public string? Locale { get; }

        public Color AccentColor { get; }

        public UserProperties PublicFlags { get; }

        public bool IsBot { get; }

        internal User(Model model)
        {
            Id = model.Id;

            if (model.Bot.IsSpecified)
                IsBot = model.Bot.Value;

            if (model.Username.IsSpecified)
                Username = model.Username.Value;

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

        internal static User Create(Model model)
            => new(model);

        internal static bool TryParse(string json, out User entity)
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
