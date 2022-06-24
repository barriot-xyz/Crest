using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Models
{
    public class Button : IComponent
    {
        [JsonProperty("type")]
        public ComponentType Type { get; set; }

        [JsonProperty("style")]
        public ButtonStyle Style { get; set; }

        [JsonProperty("label")]
        public string? Label { get; set; }

        [JsonProperty("emote")]
        public Emoji? Emoji { get; set; }

        [JsonProperty("custom_id")]
        public string? CustomId { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("disabled")]
        public bool? Disabled { get; set; }
    }
}
