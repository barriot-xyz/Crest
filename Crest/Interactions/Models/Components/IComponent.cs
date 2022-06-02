using Crest.Interactions.Properties;
using Crest.Interactions.Properties.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions.Models.Components
{
    internal interface IComponent
    {
        public ComponentType Type { get; }

        public string CustomId { get; }
    }
}
