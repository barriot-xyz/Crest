namespace Crest
{
    public sealed class DiscordClient : IClient
    {
        public DiscordClient(HttpManager manager)
        {

        }

        public Task<bool> ConfigureAsync(AuthorizationType type, string token)
        {
            throw new NotImplementedException();
        }
    }
}
