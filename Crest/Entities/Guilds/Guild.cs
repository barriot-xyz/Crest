using Crest.Api;
using Model = Crest.Entities.Guilds.Models.GuildModel;

namespace Crest.Entities
{
    public record Guild : IEntity<ulong>
    {
        private readonly CrestDiscordClient _client;

        public ulong Id { get; }

        public string Name { get; }

        internal Guild(Model model, CrestDiscordClient client)
        {
            Id = model.Id;
            Name = model.Name;
        }

        public static bool TryParse(CrestDiscordClient client, string json, out Guild entity)
        {
            var model = JsonConvert.DeserializeObject<Model>(json);

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
            => await _client.GetGuildMemberAsync(Id, id);

        public async IAsyncEnumerable<GuildMember> GetMembersAsync()
            => _client.GetGuildMembersAsync(Id);

        public async IAsyncEnumerable<GuildMember> GetMembersAsync(Predicate<string>? nameFilter = null)
            => _client.GetGuildMembersAsync(Id, nameFilter);

        public override string ToString()
            => Name;
    }
}
