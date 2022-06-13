using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Api.Requests
{
    internal readonly struct CrestRequestContext
    {
        public HttpMethod HttpMethod { get; }

        public string Uri { get; }

        public bool HeaderOnly { get; }

        public string? Json { get; }

        public string? AuditReason { get; }

        public CrestRequestContext(HttpMethod method, string endpoint, string? json = null, string? audit = null)
        {
            HttpMethod = method;
            Uri = Path.Combine(CrestConfiguration.ApiUrl, endpoint);

            HeaderOnly = json is null;
            Json = json;
            AuditReason = audit;
        }
    }
}
