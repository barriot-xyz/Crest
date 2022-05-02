using Crest.Api.Requests;
using Crest.Entities;
using System.Text;

namespace Crest.Api
{
    public sealed class CrestDiscordClient
    {
        private readonly CrestHttpManager _httpManager;

        public CrestDiscordClient(CrestHttpManager manager)
        {
            _httpManager = manager;
        }

        #region Get

        #region User

        public async Task<User> GetUserAsync(ulong id)
        {
            var result = await _httpManager.SendAsync(new(HttpMethod.Get, $"users/{id}"));

            if (User.TryParse(await result.GetJsonAsync(), out var user))
                return user;
            else
                throw new InvalidOperationException();
        }

        public async Task<GuildMember> GetGuildMemberAsync(ulong guildId, ulong id)
            => await GetGuildMemberInternalAsync(null, id, guildId);

        internal async Task<GuildMember> GetGuildMemberInternalAsync(Guild? guild, ulong id, ulong guildId = 0)
        {
            if (guild is not null)
                guildId = guild.Id;

            if (guildId is 0)
                throw new InvalidOperationException();

            var result = await GetMemberModelAsync(guildId, id);

            if (GuildMember.TryParse(await result.GetJsonAsync(), guild, out var member))
                return member;
            else
                throw new InvalidOperationException();
        }

        private async Task<CrestRequestResult> GetMemberModelAsync(ulong guildId, ulong id)
            => await _httpManager.SendAsync(new(HttpMethod.Get, $"guilds/{guildId}/members/{id}"));

        public IAsyncEnumerable<GuildMember> GetGuildmembersAsync(ulong guildId)
            => GetGuildMembersInternalAsync(null, guildId);

        internal async IAsyncEnumerable<GuildMember> GetGuildMembersInternalAsync(Guild? guild, ulong guildId = 0)
        {
            if (guild is not null)
                guildId = guild.Id;

            if (guildId is 0)
                throw new InvalidOperationException();

            var result = await _httpManager.SendAsync(new(HttpMethod.Get, $"guilds/{guildId}/members"));

            var json = await result.GetJsonAsync();
            var models = JsonConvert.DeserializeObject<IEnumerable<GuildMember>>(json);

            if (models is null)
                throw new InvalidOperationException();

            foreach(var model in models)
            {
                if (GuildMember.TryParse(await result.GetJsonAsync(), guild, out var member))
                    yield return member;
                else
                    throw new InvalidOperationException();
            }
        }

        #endregion User

        public async Task<Guild> GetGuildAsync(ulong id)
        {
            var result = await _httpManager.SendAsync(new(HttpMethod.Get, $"guilds/{id}"));

            if (Guild.TryParse(this, await result.GetJsonAsync(), out var guild))
                return guild;
            else 
                throw new ArgumentNullException(nameof(guild));
        }

        public async Task<Channel> GetChannelAsync(ulong id)
        {
            var result = await _httpManager.SendAsync(new(HttpMethod.Get, $"channels/{id}"));

            if (Channel.TryParse(await result.GetJsonAsync(), out var channel))
                return channel;
            else
                throw new ArgumentNullException(nameof(channel));
        }

        #endregion Get
    }
}
