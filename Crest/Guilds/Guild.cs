using Crest.Api;
using Crest.Api.Endpoints;

namespace Crest.Guilds
{
    public record Guild : IEntity<ulong>
    {
        private readonly GuildEndpoint _client;

        public ulong Id { get; }

        public string? Name { get; }

        internal Guild(Models.Guild model, GuildEndpoint client)
        {
            _client = client;

            Id = model.Id;
            Name = model.Name;
        }

        public static bool TryParse(GuildEndpoint client, string json, out Guild entity)
        {
            var model = JsonConvert.DeserializeObject<Models.Guild>(json);

            if (model is not null)
            {
                entity = new(model, client);
                return true;
            }
            else
            {
                entity = null!;
                return false;
            }
        }

        public async Task<bool> DeleteAsync()
            => throw new NotImplementedException();

        public async Task<IAsyncEnumerable<GuildChannel>> GetChannelsAsync()
            => throw new NotImplementedException();

        public async Task<GuildChannel> CreateChannelAsync()
            => throw new NotImplementedException();

        public async Task ModifyChannelPositions()
            => throw new NotImplementedException();

        public async Task<Thread> GetThreadsAsync()
            => throw new NotImplementedException();

        public async Task<GuildMember> GetMemberAsync(ulong id)
            => await _client.GetMemberInternalAsync(this, Id, id);

        public IAsyncEnumerable<GuildMember> GetMembersAsync()
            => _client.GetMembersInternalAsync(this, Id);

        public IAsyncEnumerable<GuildMember> GetMembersAsync(Predicate<string>? nameFilter = null)
            => _client.GetMembersInternalAsync(this, Id/*, nameFilter */);

        public override string ToString()
            => Name;
    }
}
