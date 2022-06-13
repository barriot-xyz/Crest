using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions
{
    public record SlashCommand : Command
    {
        internal SlashCommand(Models.Interaction model, Func<string, Task> callback, string timestamp) : base(model, callback, timestamp)
        {
        }

        public override Task DeferAsync(bool doEphemeral)
        {
            throw new NotImplementedException();
        }

        public override Task FollowupAsync()
        {
            throw new NotImplementedException();
        }

        public override Task RespondAsync()
        {
            throw new NotImplementedException();
        }
    }
}
