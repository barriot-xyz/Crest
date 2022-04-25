using Crest.Core;
using Model = Crest.Api.Json.UserModel;

namespace Crest.Entities
{
    public record User : IEntity<ulong>
    {
        public ulong Id { get; }

        public string Name { get; }

        public int Discriminator { get; }

        public string AvatarId { get; }

        public string BannerId { get; }

        public Color AccentColor { get; }

        internal User(Model model)
        {
            Id = model.Id;
        }

        public static bool TryParse(string json, out User entity)
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
