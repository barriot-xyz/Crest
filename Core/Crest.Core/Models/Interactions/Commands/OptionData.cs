using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Models
{
    public class OptionData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("value")]
        public object? Value { get; set; }

        [JsonProperty("options")]
        public OptionData[]? Options { get; set; }

        [JsonProperty("focussed")]
        public bool? Focussed { get; set; }
    }
}
