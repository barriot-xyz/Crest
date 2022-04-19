using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest
{
    public class CrestConfiguration
    {
        #region Standardization
        internal const string ApiUrl = "";

        internal const int MaxBansPerRequest = 1000;

        internal const int MaxMessagesPerRequest = 100;
        #endregion

        #region Application
        internal readonly string ApplicationToken;

        internal readonly AuthorizationType AuthorizationType;
        #endregion

        #region Client info
        public string UserAgent { get; }

        public Version Version { get; }
        #endregion

        public bool UseProxy { get; set; }

        public CrestConfiguration(AuthorizationType type, string token)
        {
            ApplicationToken = token;
            AuthorizationType = type;
            Version = typeof(CrestConfiguration).Assembly.GetName().Version ?? new Version(1, 0, 0, 0);
            UserAgent = $"Crest v{Version}";
        }
    }
}
