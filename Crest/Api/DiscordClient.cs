using Crest.Api.Endpoints;
using Crest.Api.Requests;
using Crest.Entities;
using System.Text;

namespace Crest.Api
{
    public sealed class DiscordClient : IClient
    {
        public ChannelEndpoint Channels { get; }

        public GuildEndpoint Guilds { get; }

        public UserEndpoint Users { get; }

        public DiscordClient(CrestHttpManager manager)
        {
            Channels = new(manager);
            Guilds   = new(manager);
            Users    = new(manager);
        }
    }
}
