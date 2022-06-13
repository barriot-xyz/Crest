using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions
{
    public record ComponentInteraction : Interaction
    {
        public string CustomId { get; }

        internal ComponentInteraction(Models.Interaction model, Func<string, Task> callback, string timestamp) : base(model, callback, timestamp)
        {
            if (model.Data is not null)
            {
                if (model.Data.CustomId is not null)
                    CustomId = model.Data.CustomId;
            }
            else
                throw new InvalidOperationException("A component interaction always contains data.");
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
