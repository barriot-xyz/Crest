﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Api.Json
{
    internal class GuildModel
    {
        [JsonProperty("snowflake")]
        public ulong Id { get; init; }

        [JsonProperty("name")]
        public string Name { get; init; } = string.Empty;
    }
}