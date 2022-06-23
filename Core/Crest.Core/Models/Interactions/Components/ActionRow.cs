using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Models
{
    public class ActionRow : IComponent
    {
        [JsonProperty("type")]
        public ComponentType Type { get; set; }

        [JsonProperty("components")]
        public IComponent Components { get; set; }

        [JsonIgnore]
        public string CustomId 
            => throw new NotSupportedException();

        public ActionRow(IComponent component)
        {
            Type = ComponentType.ActionRow;
            Components = component;
        }

        public static IEnumerable<ActionRow> CreateModalRange(IComponent[] components)
        {
            if (components.Length > 5)
                throw new NotSupportedException("Modals cannot contain more than 5 components.");

            foreach(var component in components)
            {
                if (component.Type is not ComponentType.TextInput)
                    throw new NotSupportedException("Modals only support text input components!");

                yield return new ActionRow(component);
            }
        }
    }
}
