using Crest.Emojis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions.Models.Components
{
    internal class SelectMenuOption
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("emoji")]
        public Emoji? Emoji { get; set; }

        [JsonProperty("default")]
        public bool? Default { get; set; }
    }
}
