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

        private User(Model model)
        {
            Id = model.Id;
        }

        public static async Task<User?> PopulateAsync(Stream stream)
        {
            if (stream is not null)
            {
                using var reader = new StreamReader(stream);
                var result = await reader.ReadToEndAsync();

                return new(JsonConvert.DeserializeObject<Model>(result)!);
            }
            return null;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
