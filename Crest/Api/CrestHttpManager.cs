using Crest.Api.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Api
{
    public sealed class CrestHttpManager
    {
        private readonly CrestConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public CrestHttpManager(HttpClient httpClient, CrestConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = httpClient;
        }

        internal async Task<CrestRequestResult> SendAsync(CrestRequestContext context)
        {
            using var msg = new HttpRequestMessage(context.HttpMethod, context.Uri);
            if (context.AuditReason is not null)
                msg.Headers.Add("X-Audit-Log-Reason", Uri.EscapeDataString(context.AuditReason));

            if (context.Json is not null)
                msg.Content = new StringContent(context.Json, Encoding.UTF8, "application/json");

            var value = await _httpClient.SendAsync(msg);

            var headers = value.Headers.ToDictionary(x => x.Key, x => x.Value.FirstOrDefault(), StringComparer.OrdinalIgnoreCase);
            var body = await value.Content.ReadAsStreamAsync();

            return new(value.StatusCode, headers!, body);
        }
    }
}
