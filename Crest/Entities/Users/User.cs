namespace Crest.Entities
{
    public class User : IEntity
    {
        [JsonProperty("snowflake")]
        public ulong Id { get; init; }

        [JsonProperty("username")]
        public string Username { get; init; } = "Unknown";

        [JsonProperty("discriminator")]
        public int Discriminator { get; init; } = 0000;

        [JsonProperty("nickname")]
        public string? Nickname { get; init; }

        [JsonIgnore]
        public string DisplayName
        {
            get
                => Nickname ?? Username;
        }

        private EntityFlags _flags;

        [JsonIgnore]
        public EntityFlags Flags
        {
            get
                => _flags;
            init
                => _flags = GetFlags();
        }

        private EntityFlags GetFlags()
        {
            EntityFlags flags = EntityFlags.None;

            if (Nickname is not null)
                flags |= EntityFlags.FromGuild;

            return flags;
        }

        public override string ToString()
            => Username + "#" + Discriminator;
    }
}
