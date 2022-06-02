using Crest.Api.Endpoints;
using Crest.Entities.Users.Properties;
using Model = Crest.Entities.Users.Models.User;

namespace Crest.Users
{
    public record CurrentUser : User
    {
        public UserProperties Flags { get; }

        public string? Email { get; }

        public bool MFAEnabled { get; }

        public bool IsVerified { get; }

        internal CurrentUser(Model model, UserEndpoint client) : base(model, client)
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
    }
}
