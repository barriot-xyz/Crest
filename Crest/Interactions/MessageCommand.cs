﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions
{
    public class MessageCommand : Command
    {
        internal MessageCommand(Models.Interaction model, string timestamp) : base(model, timestamp)
        {
        }
    }
}
