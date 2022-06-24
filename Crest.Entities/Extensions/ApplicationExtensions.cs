using Microsoft.Extensions.DependencyInjection;
using System.Net;

namespace Crest
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddCrestClient(this IServiceCollection services, ClientConfiguration configuration)
        {
            services.AddSingleton<ClientConfiguration>(configuration);
            services.AddHttpClient<IClient, DiscordClient>()
                .ConfigureHttpClient(x =>
                {
                    x.BaseAddress = new Uri(ClientConfiguration.ApiUrl);
                    x.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate");
                    x.DefaultRequestHeaders.Add("Authorization", $"{configuration.AuthorizationType} {configuration.ApplicationToken}");
                    x.DefaultRequestHeaders.Add("accept", "*/*");
                    x.DefaultRequestHeaders.Add("user-agent", configuration.UserAgent);
                })
                .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler()
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                    UseCookies = false,
                    UseProxy = configuration.UseProxy,
                });
            return services;
        }
    }
}
