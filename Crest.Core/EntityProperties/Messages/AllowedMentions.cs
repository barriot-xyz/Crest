using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest
{
    public class AllowedMentions
    {
        [JsonProperty("parse")]
        public string[] MentionTypes { get; set; } = Array.Empty<string>();

        [JsonProperty("roles")]
        public ulong[]? RoleIds { get; set; }

        [JsonProperty("users")]
        public ulong[]? UserIds { get; set; }

        [JsonProperty("replied_user")]
        public bool AllowMentionReply { get; set; }
    }
}
