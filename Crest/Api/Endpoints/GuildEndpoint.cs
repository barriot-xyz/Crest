using Crest.Api.Requests;
using Crest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Api.Endpoints
{
    public class GuildEndpoint
    {
        private readonly CrestHttpManager _manager;

        public GuildEndpoint(CrestHttpManager manager)
        {
            _manager = manager;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<Guild> GetOneAsync(ulong id)
        {
            var result = await _manager.SendAsync(new(HttpMethod.Get, $"guilds/{id}"));

            if (Guild.TryParse(this, await result.GetJsonAsync(), out var guild))
                return guild;
            else
                throw new ArgumentNullException(nameof(guild));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="guildId"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<GuildMember> GetMemberAsync(ulong guildId, ulong id)
            => await GetMemberInternalAsync(null, id, guildId);

        internal async Task<GuildMember> GetMemberInternalAsync(Guild? guild, ulong id, ulong guildId = 0)
        {
            if (guild is not null)
                guildId = guild.Id;

            if (guildId is 0)
                throw new InvalidOperationException();

            var result = await GetMemberModelAsync(guildId, id);

            if (GuildMember.TryParse(await result.GetJsonAsync(), guild, guildId, out var member))
                return member;
            else
                throw new InvalidOperationException();
        }

        private async Task<CrestRequestResult> GetMemberModelAsync(ulong guildId, ulong id)
            => await _manager.SendAsync(new(HttpMethod.Get, $"guilds/{guildId}/members/{id}"));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="guildId"></param>
        /// <returns></returns>
        public IAsyncEnumerable<GuildMember> GetMembersAsync(ulong guildId)
            => GetMembersInternalAsync(null, guildId);

        internal async IAsyncEnumerable<GuildMember> GetMembersInternalAsync(Guild? guild, ulong guildId = 0)
        {
            if (guild is not null)
                guildId = guild.Id;

            if (guildId is 0)
                throw new InvalidOperationException();

            var result = await _manager.SendAsync(new(HttpMethod.Get, $"guilds/{guildId}/members"));

            var json = await result.GetJsonAsync();
            var models = JsonConvert.DeserializeObject<IEnumerable<GuildMember>>(json);

            if (models is null)
                throw new InvalidOperationException();

            foreach (var model in models)
            {
                if (GuildMember.TryParse(await result.GetJsonAsync(), guild, guildId, out var member))
                    yield return member;
                else
                    throw new InvalidOperationException();
            }
        }
    }
}
