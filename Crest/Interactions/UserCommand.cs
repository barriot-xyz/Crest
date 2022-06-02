using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions
{
    public class UserCommand : Command
    {
        internal UserCommand(Models.Interaction model, string timestamp) : base(model, timestamp)
        {
        }
    }
}
