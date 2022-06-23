using Model = Crest.Models.Interaction;

namespace Crest
{
    public record ModalInteraction : Interaction, IClientInteraction
    {
        internal ModalInteraction(Models.Interaction model, Func<string, Task> callback, string timestamp, DiscordClient client) 
            : base(model, callback, timestamp, client)
        {
        }

        public Task DeferAsync(bool doEphemeral)
        {
            throw new NotImplementedException();
        }

        public Task FollowupAsync()
        {
            throw new NotImplementedException();
        }

        public Task RespondAsync()
        {
            throw new NotImplementedException();
        }
    }
}
