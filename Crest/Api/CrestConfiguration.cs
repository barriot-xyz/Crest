using Crest.Core;
using Newtonsoft.Json.Serialization;

namespace Crest
{
    public class CrestConfiguration
    {
        #region readonly
        internal const string ApiUrl = "";

        internal const int MaxBansPerRequest = 1000;

        internal const int MaxMessagesPerRequest = 100;

        internal readonly string ApplicationToken;

        internal readonly AuthorizationType AuthorizationType;
        #endregion

        public static JsonSerializer Serializer { get; private set; } = new JsonSerializer() { NullValueHandling = NullValueHandling.Ignore };

        public string UserAgent { get; }

        public Version Version { get; }

        public bool UseProxy { get; set; }

        public CrestConfiguration(JsonSerializer? serializer, AuthorizationType type, string token)
        {
            if (serializer is not null)
                Serializer = serializer;

            ApplicationToken = token;
            AuthorizationType = type;

            Version = typeof(CrestConfiguration).Assembly.GetName().Version ?? new Version(1, 0, 0, 0);
            UserAgent = $"Crest v{Version}";
        }

        public CrestConfiguration(AuthorizationType type, string token) 
            : this(null, type, token)
        {
        }
    }
}
