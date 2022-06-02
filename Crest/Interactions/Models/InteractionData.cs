using Crest.Interactions.Models.Components;
using Crest.Interactions.Properties;
using Crest.Interactions.Properties.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions.Models
{
    internal class InteractionData
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public ApplicationCommandType Type { get; set; }

        //[JsonProperty("resolved")]
        //public Resolved? Resolved { get; set; }

        //[JsonProperty("options")]
        //public Options? Options { get; set; }

        [JsonProperty("guild_id")]
        public ulong? GuildId { get; set; }

        [JsonProperty("custom_id")]
        public string? CustomId { get; set; }

        [JsonProperty("component_type")]
        public ComponentType? ComponentType { get; set; }

        [JsonProperty("values")]
        public string[]? Values { get; set; }

        [JsonProperty("target_id")]
        public ulong TargetId { get; set; }

        [JsonProperty("components")]
        public ActionRow[] Components { get; set; }
    }
}
