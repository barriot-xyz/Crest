namespace Crest.Entities
{
    public record Guild : IEntity<ulong>
    {
        public ulong Id { get; }

        internal Guild()
        {
            Id = 0;
        }

        public async Task<bool> DeleteAsync() { }

        public async Task<IAsyncEnumerable<GuildChannel>> GetChannelsAsync() { }

        public async Task<GuildChannel> CreateChannelAsync() { }

        public async Task ModifyChannelPositions() { }

        public async Task<Thread> GetThreadsAsync() { }

        public async Task<GuildMember> GetMemberAsync(ulong id) { }

        public async Task<IAsyncEnumerable<GuildMember>> GetMembersAsync(Predicate<string>? nameFilter = null) { }

        public async Task<bool> AddMemberAsync() { }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
