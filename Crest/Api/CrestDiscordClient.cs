using Crest.Api.Requests;
using Crest.Entities;
using System.Text;

namespace Crest.Api
{
    public sealed class CrestDiscordClient
    {
        private readonly CrestConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public CrestDiscordClient(HttpClient httpClient, CrestConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = httpClient;
        }

        public async Task<User> GetUserAsync(ulong id)
        {
            var result = await SendAsync(new(HttpMethod.Get, $"users/{id}"));

            return await User.PopulateAsync(result.Body) 
                ?? throw new ArgumentOutOfRangeException(nameof(id));
        }

        public async Task<Guild> GetGuildAsync(ulong id)
        {
            var result = await SendAsync(new(HttpMethod.Get, $"guilds/{id}"));

            return await Guild.PopulateAsync(result.Body)
                ?? throw new ArgumentOutOfRangeException(nameof(id));
        }

        public async Task<Channel> GetChannelAsync(ulong id)
        {
            var result = await SendAsync(new(HttpMethod.Get, $"channels/{id}"));

            return await Channel.PopulateAsync(result.Body)
                ?? throw new ArgumentOutOfRangeException(nameof(id));
        }

        private async Task<CrestRequestResult> SendAsync(CrestRequestContext context)
        {
            using var msg = new HttpRequestMessage(context.HttpMethod, context.Uri);
            if (context.AuditReason is not null)
                msg.Headers.Add("X-Audit-Log-Reason", Uri.EscapeDataString(context.AuditReason));

            if (context.Json is not null)
                msg.Content = new StringContent(context.Json, Encoding.UTF8, "application/json");

            var value = await _httpClient.SendAsync(msg);

            var headers = value.Headers.ToDictionary(x => x.Key, x => x.Value.FirstOrDefault(), StringComparer.OrdinalIgnoreCase);
            var body = await value.Content.ReadAsStreamAsync();

            return new(value.StatusCode, headers, body);
        }
    }
}
