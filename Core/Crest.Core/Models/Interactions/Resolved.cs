using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Models
{
    public class Resolved
    {
        [JsonProperty("users")]
        public Dictionary<string, User>? Users { get; set; }

        [JsonProperty("members")]
        public Dictionary<string, Member>? Members { get; set; }

        [JsonProperty("channels")]
        public Dictionary<string, Channel>? Channels { get; set; }

        [JsonProperty("roles")]
        public Dictionary<string, Role>? Roles { get; set; }

        [JsonProperty("messages")]
        public Dictionary<string, Message>? Messages { get; set; }

        //[JsonProperty("attachments")]
        //public Dictionary<string, Attachment> Attachments { get; set; }
    }
}
