using Crest.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions
{
    public record MessageCommand : Command
    {
        public ulong MessageId { get; }

        public Message Message { get; }

        internal MessageCommand(Models.Interaction model, string timestamp) : base(model, timestamp)
        {
            var data = model.Data!;

            MessageId = data.TargetId;
        }
    }
}
