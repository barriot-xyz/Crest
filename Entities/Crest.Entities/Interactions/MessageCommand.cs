using Model = Crest.Models.Interaction;

namespace Crest
{
    public record MessageCommand : CommandInteraction
    {
        public ulong MessageId { get; }

        public Message Message { get; }

        internal MessageCommand(Models.Interaction model, Func<string, Task> callback, string timestamp, DiscordClient client) 
            : base(model, callback, timestamp, client)
        {
            var data = model.Data!;

            MessageId = data.TargetId;
        }

        public override Task DeferAsync(bool doEphemeral)
        {
            throw new NotImplementedException();
        }

        public override Task RespondAsync()
        {
            throw new NotImplementedException();
        }

        public override Task FollowupAsync()
        {
            throw new NotImplementedException();
        }
    }
}
