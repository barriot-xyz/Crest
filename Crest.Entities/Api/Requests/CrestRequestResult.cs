using System.Net;

namespace Crest
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

        public async Task<string> GetJsonAsync()
        {
            if (Body is not null)
            {
                using var reader = new StreamReader(Body);
                var json = await reader.ReadToEndAsync();
                return json;
            }
            else return string.Empty;
        }
    }
}
