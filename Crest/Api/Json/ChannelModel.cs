﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Api.Json
{
    internal class ChannelModel
    {
        [JsonProperty("snowflake")]
        public ulong Id { get; init; }
    }
}
