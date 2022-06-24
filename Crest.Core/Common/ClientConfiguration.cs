namespace Crest
{
    public class ClientConfiguration
    {
        #region readonly
        public const string ApiUrl = "";

        internal const int MaxBansPerRequest = 1000;

        internal const int MaxMessagesPerRequest = 100;

        public readonly string ApplicationToken;

        public readonly AuthorizationType AuthorizationType;
        #endregion

        public static JsonSerializer Serializer { get; private set; } = new() 
        { 
            NullValueHandling = NullValueHandling.Ignore, 
            Formatting = Formatting.Indented 
        };

        public string UserAgent { get; }

        public Version Version { get; }

        public bool UseProxy { get; set; }

        public ClientConfiguration(JsonSerializer? serializer, AuthorizationType type, string token)
        {
            if (serializer is not null)
                Serializer = serializer;

            ApplicationToken = token;
            AuthorizationType = type;

            Version = typeof(ClientConfiguration).Assembly.GetName().Version ?? new Version(1, 0, 0, 0);
            UserAgent = $"Crest v{Version}";
        }

        public ClientConfiguration(AuthorizationType type, string token) 
            : this(null, type, token)
        {
        }
    }
}
