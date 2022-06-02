using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Api.Json
{
    internal class BanModel
    {
        [JsonProperty("user_id")]
        public ulong Id { get; init; }
    }
}
