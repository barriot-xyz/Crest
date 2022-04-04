namespace Crest.Api
{
    public class CrestDiscordClient : IDisposable
    {
        internal CrestConfiguration Configuration { get; }

        public CrestDiscordClient(CrestConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task LoginAsync(string token)
        {

        }

        public async Task LogoutAsync()
        {

        }

        async void IDisposable.Dispose()
        {
            await LogoutAsync();
        }
    }
}
