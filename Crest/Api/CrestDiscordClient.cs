using Crest.Api.Endpoints;
using Crest.Api.Requests;
using Crest.Entities;
using System.Text;

namespace Crest.Api
{
    public sealed class CrestDiscordClient
    {
        public ChannelEndpoint ChannelEndpoint { get; }

        public GuildEndpoint GuildEndpoint { get; }

        public UserEndpoint UserEndpoint { get; }

        public CrestDiscordClient(CrestHttpManager manager)
        {
            ChannelEndpoint = new(manager);
            GuildEndpoint   = new(manager);
            UserEndpoint    = new(manager);
        }
    }
}
