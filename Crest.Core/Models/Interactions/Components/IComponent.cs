using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Models
{
    public interface IComponent
    {
        public ComponentType Type { get; }

        public string CustomId { get; }
    }
}
