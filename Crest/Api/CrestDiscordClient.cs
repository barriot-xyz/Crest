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
    }
}
