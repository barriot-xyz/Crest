using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Models
{
    public class OptionChoice
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_localizations")]
        public string? NameLocalizations { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
    }
}
