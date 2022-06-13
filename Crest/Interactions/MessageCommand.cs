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

        internal MessageCommand(Models.Interaction model, Func<string, Task> callback, string timestamp) : base(model, callback, timestamp)
        {
            var data = model.Data!;

            MessageId = data.TargetId;
        }

        public override Task DeferAsync(bool doEphemeral)
        {
            throw new NotImplementedException();
        }

        public override Task RespondAsync()
        {
            throw new NotImplementedException();
        }

        public override Task FollowupAsync()
        {
            throw new NotImplementedException();
        }
    }
}
