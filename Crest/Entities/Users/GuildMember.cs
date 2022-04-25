using Crest.Core;

namespace Crest.Entities
{
    public record GuildMember : User
    {
        public string Nickname { get; }

        public string GuildBannerId { get; }

        public string GuildAvatarId { get; }

        public Color AccentColor { get; }

        public GuildMember() : base()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
