using Model = Crest.Models.Interaction;

namespace Crest
{
    public record ComponentInteraction : Interaction, IClientInteraction
    {
        public string CustomId { get; }

        internal ComponentInteraction(Model model, Func<string, Task> callback, string timestamp, DiscordClient client) 
            : base(model, callback, timestamp, client)
        {
            if (model.Data is not null)
            {
                CustomId = model.Data.CustomId ?? string.Empty;
            }
            else
                throw new InvalidOperationException("A component interaction always contains data.");
        }

        public Task DeferAsync(bool doEphemeral)
        {
            throw new NotImplementedException();
        }

        public Task DeferLoadingAsync(bool doEphemeral)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }

        public Task RespondAsync()
        {
            throw new NotImplementedException();
        }

        public Task FollowupAsync()
        {
            throw new NotImplementedException();
        }
    }
}
