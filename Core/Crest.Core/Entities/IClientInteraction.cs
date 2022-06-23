using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest
{
    public interface IClientInteraction
    {
        public Task DeferAsync(bool doEphemeral);

        public Task RespondAsync();

        public Task FollowupAsync();
    }
}
