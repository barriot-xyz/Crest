﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Channels.Models
{
    internal class Channel
    {
        [JsonProperty("snowflake")]
        public ulong Id { get; init; }
    }
}