using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Models
{
    public class Emoji
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("roles")]
        public ulong[]? RoleIds { get; set; }

        [JsonProperty("user")]
        public User? User { get; set; }

        [JsonProperty("require_colons")]
        public bool? RequiresColons { get; set; }

        [JsonProperty("managed")]
        public bool? Managed { get; set; }

        [JsonProperty("animated")]
        public bool? Animated { get; set; }

        [JsonProperty("available")]
        public bool? Available { get; set; }
    }
}
