using Model = Crest.Models.Interaction;

namespace Crest
{
    public record UserCommand : CommandInteraction
    {
        internal UserCommand(Model model, Func<string, Task> callback, string timestamp, DiscordClient client) 
            : base(model, callback, timestamp, client)
        {
        }

        public override Task DeferAsync(bool doEphemeral)
        {
            throw new NotImplementedException();
        }

        public override Task FollowupAsync(MessageContent content)
        {
            throw new NotImplementedException();
        }

        public override Task RespondAsync(MessageContent content)
        {
            throw new NotImplementedException();
        }
    }
}
