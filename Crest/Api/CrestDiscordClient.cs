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
                throw new ArgumentNullException(nameof(user));
        }

        public async Task<GuildMember> GetGuildMemberAsync(ulong guildId, ulong Id)
        {
            var result = await _httpManager.SendAsync(new(HttpMethod.Get, $"guilds/{guildId}/members/{Id}"));

            if (GuildMember.TryParse(await result.GetJsonAsync(), out var member))
                return member;
            else
                throw new ArgumentNullException(nameof(member));
        }

        public async IAsyncEnumerable<GuildMember> GetGuildMembersAsync(ulong guildId)
        {
            var result = await _httpManager.SendAsync(new(HttpMethod.Get, $"guilds/{guildId}/members"));

            var json = await result.GetJsonAsync();
            var models = JsonConvert.DeserializeObject<IEnumerable<GuildMember>>(json);

            if (models is null)
                throw new ArgumentNullException(nameof(models));

            foreach(var model in models)
            {
                if (GuildMember.TryParse(await result.GetJsonAsync(), out var member))
                    yield return member;
                else
                    throw new ArgumentNullException(nameof(member));
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
