using Crest.Interactions.Properties;
using Crest.Messages.Models;
using Crest.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions.Models
{
    /// <summary>
    ///     https://discord.com/developers/docs/interactions/receiving-and-responding#interaction-object-interaction-structure
    /// </summary>
    internal class Interaction
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("application_id")]
        public ulong AppId { get; set; }

        [JsonProperty("type")]
        public InteractionType Type { get; set; }

        [JsonProperty("data")]
        public InteractionData? Data { get; set; }

        [JsonProperty("guild_id")]
        public ulong? GuildId { get; set; }

        [JsonProperty("channel_id")]
        public ulong? ChannelId { get; set; }

        [JsonProperty("member")]
        public Member? Member { get; set; }

        [JsonProperty("user")]
        public User? User { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("message")]
        public Message? Message { get; set; }

        [JsonProperty("locale")]
        public string? Locale { get; set; }

        [JsonProperty("guild_locale")]
        public string? GuildLocale { get; set; }
    }
}
