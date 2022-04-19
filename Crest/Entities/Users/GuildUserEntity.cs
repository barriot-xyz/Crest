using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Entities.Users
{
    public record GuildUserEntity : UserEntity
    {
        public string Nickname { get; }

        public string GuildBannerId { get; }

        public string GuildAvatarId { get; }

        public Color AccentColor { get; }

        public GuildUserEntity()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
