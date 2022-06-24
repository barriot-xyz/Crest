using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Models
{
    public class Option
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_localizations")]
        public string? NameLocalizations { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("description_localizations")]
        public string? DescriptionLocalizations { get; set; }
        
        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("choices")]
        public OptionChoice[]? Choices { get; set; }

        [JsonProperty("options")]
        public OptionData[]? Options { get; set; }

        [JsonProperty("channel_types")]
        public int[]? ChannelTypes { get; set; }

        [JsonProperty("min_value")]
        public int? MinValue { get; set; }

        [JsonProperty("max_value")]
        public int? MaxValue { get; set; }

        [JsonProperty("autocomplete")]
        public bool? AutoComplete { get; set; }
    }
}
