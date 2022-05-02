using Crest.Entities.Users.Properties;
using Model = Crest.Entities.Users.Models.UserModel;

namespace Crest.Entities
{
    public record CurrentUser : User
    {
        public UserProperties Flags { get; }

        public string? Email { get; }

        public bool MFAEnabled { get; }

        public bool IsVerified { get; }

        internal CurrentUser(Model model) : base(model)
        {
            if (model.Flags.IsSpecified)
                Flags = model.Flags.Value;

            if (model.Email.IsSpecified)
                Email = model.Email.Value;

            if (model.MFAEnabled.IsSpecified)
                MFAEnabled = model.MFAEnabled.Value;

            if (model.Verified.IsSpecified)
                IsVerified = model.Verified.Value;
        }

        internal static CurrentUser Create(Model model)
            => new(model);
    }
}
