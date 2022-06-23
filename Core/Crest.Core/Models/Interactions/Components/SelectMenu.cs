using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Models
{
    public class SelectMenu : IComponent
    {
        [JsonProperty("type")]
        public ComponentType Type { get; set; }

        [JsonProperty("custom_id")]
        public string CustomId { get; set; }

        [JsonProperty("options")]
        public SelectMenuOption[] Options { get; set; }

        [JsonProperty("placeholder")]
        public string? Placeholder { get; set; }

        [JsonProperty("min_values")]
        public int? MinValues { get; set; }

        [JsonProperty("max_values")]
        public int? MaxValues { get; set; }

        [JsonProperty("disabled")]
        public bool? Disabled { get; set; }
    }
}
