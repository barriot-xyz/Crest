
namespace Crest.Users.Models
{
    internal class Member
    {
        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("nick")]
        public string? Nickname { get; set; }

        [JsonProperty("avatar")]
        public string? Avatar { get; set; }

        [JsonProperty("roles")]
        public ulong[]? Roles { get; set; }

        [JsonProperty("joined_at")]
        public DateTimeOffset? JoinedAt { get; set; }

        [JsonProperty("deaf")]
        public bool? Deaf { get; set; }

        [JsonProperty("mute")]
        public bool? Mute { get; set; }

        [JsonProperty("pending")]
        public bool? Pending { get; set; }

        [JsonProperty("premium_since")]
        public DateTimeOffset? PremiumSince { get; set; }

        [JsonProperty("communication_disabled_until")]
        public DateTimeOffset? TimedOutUntil { get; set; }
    }
}
