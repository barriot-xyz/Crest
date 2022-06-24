using Newtonsoft.Json;
using Model = Crest.Models.Member;

namespace Crest
{
    public record GuildMember : User
    {
        public ulong GuildId { get; }

        public string? Nickname { get; }

        public string? GuildAvatarId { get; }

        public bool IsDeafened { get; }

        public bool IsMuted { get; }

        public bool IsPending { get; }

        public DateTimeOffset? TimedOutUntil { get; }

        public DateTimeOffset? BoostingSince { get; }

        public DateTimeOffset JoinedAt { get; }

        public ulong[] RoleIds { get; }

        internal GuildMember(Model model, Guild? guild, ulong guildId, DiscordClient client) : base(model.User, client)
        {
            if (guild is null && guildId is 0)
                throw new InvalidOperationException();

            GuildId = guildId;

            Nickname = model.Nickname ?? string.Empty;
            GuildAvatarId = model.Avatar;
            IsDeafened = model.Deaf ?? false;
            IsMuted = model.Mute ?? false;
            TimedOutUntil = model.TimedOutUntil ?? null;
            RoleIds = model.Roles ?? Array.Empty<ulong>();
            IsPending = model.Pending ?? false;
            JoinedAt = model.JoinedAt ?? DateTimeOffset.UtcNow;
            BoostingSince = model.PremiumSince ?? null;
        }

        internal static bool TryParse(DiscordClient client, string json, Guild? guild, ulong guildId, out GuildMember entity)
        {
            var model = JsonConvert.DeserializeObject<Model>(json);

            if (model is not null)
            {
                entity = new(model, guild, guildId, client);
                return true;
            }
            else
            {
                entity = null!;
                return false;
            }
        }

        public override string ToString()
            => $"<@{Id}>";
    }
}
