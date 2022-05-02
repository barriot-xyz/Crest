﻿
namespace Crest.Entities.Users.Models
{
    internal class GuildMemberModel
    {
        [JsonProperty("user")]
        public UserModel User { get; set; }

        [JsonProperty("nick")]
        public Optional<string> Nickname { get; set; }

        [JsonProperty("avatar")]
        public Optional<string> Avatar { get; set; }

        [JsonProperty("roles")]
        public Optional<ulong[]> Roles { get; set; }

        [JsonProperty("joined_at")]
        public Optional<DateTimeOffset> JoinedAt { get; set; }

        [JsonProperty("deaf")]
        public Optional<bool> Deaf { get; set; }

        [JsonProperty("mute")]
        public Optional<bool> Mute { get; set; }

        [JsonProperty("pending")]
        public Optional<bool> Pending { get; set; }

        [JsonProperty("premium_since")]
        public Optional<DateTimeOffset?> PremiumSince { get; set; }

        [JsonProperty("communication_disabled_until")]
        public Optional<DateTimeOffset?> TimedOutUntil { get; set; }
    }
}