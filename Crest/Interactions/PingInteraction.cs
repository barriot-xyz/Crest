using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions
{
    public class PingInteraction : Interaction
    {
        internal PingInteraction(Models.Interaction model, string timestamp) : base(model, timestamp)
        {
        }
    }
}
