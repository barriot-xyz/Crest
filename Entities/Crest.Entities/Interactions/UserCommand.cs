using Model = Crest.Models.Interaction;

namespace Crest
{
    public record UserCommand : CommandInteraction
    {
        internal UserCommand(Models.Interaction model, Func<string, Task> callback, string timestamp, DiscordClient client) 
            : base(model, callback, timestamp, client)
        {
        }

        public override Task DeferAsync(bool doEphemeral)
        {
            throw new NotImplementedException();
        }

        public override Task FollowupAsync()
        {
            throw new NotImplementedException();
        }

        public override Task RespondAsync()
        {
            throw new NotImplementedException();
        }
    }
}
