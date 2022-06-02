using Crest.Api.Endpoints;
using Model = Crest.Entities.Users.Models.GuildMember;

namespace Crest.Users
{
    public record GuildMember : User
    {
        public ulong GuildId { get; }

        public Guild? Guild { get; }

        public string? Nickname { get; }

        public string? GuildAvatarId { get; }

        public bool IsDeafened { get; }

        public bool IsMuted { get; }

        public bool IsPending { get; }

        public DateTimeOffset? TimedOutUntil { get; }

        public DateTimeOffset? BoostingSince { get; }

        public DateTimeOffset JoinedAt { get; }

        public ulong[] RoleIds { get; } = Array.Empty<ulong>();

        internal GuildMember(Model model, Guild? guild, ulong guildId, UserEndpoint client) : base(model.User, client)
        {
            if (guild is null && guildId is 0)
                throw new InvalidOperationException();

            else if (guild is not null)
                Guild = guild;

            GuildId = guildId;

            if (model.Nickname.IsSpecified)
                Nickname = model.Nickname.Value;

            if (model.Avatar.IsSpecified)
                GuildAvatarId = model.Avatar.Value;

            if (model.Deaf.IsSpecified)
                IsDeafened = model.Deaf.Value;

            if (model.Mute.IsSpecified)
                IsMuted = model.Mute.Value;

            if (model.TimedOutUntil.IsSpecified)
                TimedOutUntil = model.TimedOutUntil.Value;

            if (model.Roles.IsSpecified)
                RoleIds = model.Roles.Value;

            if (model.Pending.IsSpecified)
                IsPending = model.Pending.Value;

            if (model.JoinedAt.IsSpecified)
                JoinedAt = model.JoinedAt.Value;

            if (model.PremiumSince.IsSpecified)
                BoostingSince = model.PremiumSince.Value;
        }

        internal static bool TryParse(UserEndpoint client, string json, Guild? guild, ulong guildId, out GuildMember entity)
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

        public async Task<IEnumerable<Role>> GetRolesAsync()
        {
            await Task.CompletedTask;
            throw null!;
        }

        public override string ToString()
            => $"<@{Id}>";
    }
}
