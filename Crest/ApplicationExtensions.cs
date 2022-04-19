using Crest.Api;
using Crest.Interaction;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Crest
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddCrestClient(this IServiceCollection services, CrestConfiguration configuration)
        {
            services.AddSingleton<CrestConfiguration>(configuration);
            services.AddHttpClient<CrestDiscordClient>()
                .ConfigureHttpClient(x =>
                {
                    x.BaseAddress = new Uri(CrestConfiguration.ApiUrl);
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
