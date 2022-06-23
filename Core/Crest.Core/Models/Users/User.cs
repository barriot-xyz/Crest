namespace Crest.Models
{
    public class User
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("discriminator")]
        public string? Discriminator { get; set; }

        [JsonProperty("bot")]
        public bool? Bot { get; set; }

        [JsonProperty("avatar")]
        public string? Avatar { get; set; }

        [JsonProperty("banner")]
        public string? Banner { get; set; }

        [JsonProperty("accent_color")]
        public uint? AccentColor { get; set; }

        //CurrentUser
        [JsonProperty("verified")]
        public bool? Verified { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("mfa_enabled")]
        public bool? MFAEnabled { get; set; }

        [JsonProperty("flags")]
        public UserProperties? Flags { get; set; }

        [JsonProperty("premium_type")]
        public PremiumType? PremiumType { get; set; }

        [JsonProperty("locale")]
        public string? Locale { get; set; }

        [JsonProperty("public_flags")]
        public UserProperties? PublicFlags { get; set; }
    }
}
