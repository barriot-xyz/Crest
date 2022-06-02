using Crest.Interactions.Properties;
using Crest.Interactions.Properties.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions.Models.Components
{
    internal class ActionRow : IComponent
    {
        [JsonProperty("type")]
        public ComponentType Type { get; set; }

        [JsonProperty("components")]
        public IComponent Components { get; set; }

        [JsonIgnore]
        public string CustomId 
            => throw new NotSupportedException();
    }
}
