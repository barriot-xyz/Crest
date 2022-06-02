using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Converters
{
    internal static class SnowflakeConverter
    {
        public static DateTimeOffset ToTimestamp(string value)
            => ToTimestamp(ulong.Parse(value));

        public static DateTimeOffset ToTimestamp(ulong value)
            => DateTimeOffset.FromUnixTimeMilliseconds((long)((value >> 22) + 1420070400000UL));

        public static ulong ToId(DateTimeOffset value)
            => ((ulong)value.ToUnixTimeMilliseconds() - 1420070400000UL) << 22;
    }
}
