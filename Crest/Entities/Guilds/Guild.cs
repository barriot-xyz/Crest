using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Entities
{
    public class Guild : IEntity
    {
        public ulong Id { get; }

        internal Guild()
        {
            Id = 0;
        }

        public async Task DeleteAsync() { }

        public async Task GetChannelsAsync() { }

        public async Task CreateChannelAsync() { }

        public async Task ModifyChannelPositions() { }

        public async Task GetThreadsAsync() { }

        public async Task GetMemberAsync(ulong snowflake) { }

        public async Task GetMembersAsync(Predicate<string>? nameFilter = null) { }

        public async Task AddMemberAsync() { }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
