using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions
{
    public class ModalInteraction : Interaction
    {
        internal ModalInteraction(Models.Interaction model, string timestamp) : base(model, timestamp)
        {
        }
    }
}
