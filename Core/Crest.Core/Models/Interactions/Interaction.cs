using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Models
{
    public class Interaction
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("application_id")]
        public ulong AppId { get; set; }

        /// <summary>
        ///     Always present.
        /// </summary>
        [JsonProperty("type")]
        public InteractionType Type { get; set; }

        /// <summary>
        ///     Always present.
        /// </summary>
        [JsonProperty("data")]
        public InteractionData? Data { get; set; }

        /// <summary>
        ///     The ID of the guild.
        /// </summary>
        [JsonProperty("guild_id")]
        public ulong? GuildId { get; set; }

        /// <summary>
        ///     The ID of the channel.
        /// </summary>
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
