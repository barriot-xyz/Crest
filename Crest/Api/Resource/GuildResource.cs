using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Api.Resources
{
    public class GuildResource : IResource
    {
        /// <inheritdoc/>
        public string Route { get; } = "/guilds/";

        public async Task DeleteAsync() { }

        public async Task GetChannelsAsync() { }

        public async Task CreateChannelAsync() { }

        public async Task ModifyChannelPositions() { }

        public async Task GetThreadsAsync() { }

        public async Task GetMemberAsync(ulong snowflake) { }

        public async Task GetMembersAsync(Predicate<string>? nameFilter = null) { }

        public async Task AddMemberAsync()
    }
}
