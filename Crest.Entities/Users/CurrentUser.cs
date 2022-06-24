using Model = Crest.Models.User;

namespace Crest
{
    public record CurrentUser : User
    {
        public UserProperties Flags { get; }

        public string? Email { get; }

        public bool MFAEnabled { get; }

        public bool IsVerified { get; }

        internal CurrentUser(Model model, DiscordClient client) : base(model, client)
        {
            Flags = model.Flags ?? UserProperties.None;
            Email = model.Email;
            MFAEnabled = model.MFAEnabled ?? false;
            IsVerified = model.Verified ?? false;
        }
    }
}
