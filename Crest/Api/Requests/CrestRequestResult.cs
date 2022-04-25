using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Api.Requests
{
    internal struct CrestRequestResult
    {
        public Dictionary<string, string> Headers { get; }

        public HttpStatusCode StatusCode { get; }

        public Stream Body { get; }

        internal CrestRequestResult(HttpStatusCode statusCode, Dictionary<string, string> headers, Stream body)
        {
            Headers = headers;
            StatusCode = statusCode;
            Body = body;
        }
    }
}
