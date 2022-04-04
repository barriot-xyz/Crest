using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest
{
    /// <summary>
    ///     Represents a snowflake on Discord.
    /// </summary>
    public class Snowflake
    {
        public ulong Id { get; }

        private Snowflake(ulong id)
            => Id = id;

        private Snowflake(byte epoch)
            => Id = Convert.ToUInt64(epoch << 22);

        public static implicit operator Snowflake(byte epoch)
            => new Snowflake(epoch);

        public static implicit operator Snowflake(ulong id)
            => new Snowflake(id);

        public static implicit operator ulong(Snowflake flake)
            => flake.Id;
    }
}
