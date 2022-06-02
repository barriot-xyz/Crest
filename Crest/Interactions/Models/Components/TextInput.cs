using Crest.Interactions.Properties;
using Crest.Interactions.Properties.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions.Models.Components
{
    internal class TextInput : IComponent
    {
        [JsonProperty("type")]
        public ComponentType Type { get; set; }

        [JsonProperty("custom_id")]
        public string CustomId { get; set; }

        [JsonProperty("style")]
        public TextInputStyle Style { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("min_length")]
        public int? MinLength { get; set; }

        [JsonProperty("max_length")]
        public int? MaxLength { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }

        [JsonProperty("placeholder")]
        public string? Placeholder { get; set; }
    }
}
