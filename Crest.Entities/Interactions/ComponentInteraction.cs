using Crest.Models;
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

        public async Task DeferAsync(bool doEphemeral)
        {
            var str = new InteractionResponse(ResponseType.Defer, new(doEphemeral, false));

            await Callback(str.Serialize());
        }

        public async Task DeferLoadingAsync(bool doEphemeral)
        {
            var str = new InteractionResponse(ResponseType.Defer, new(doEphemeral, true));

            await Callback(str.Serialize());
        }

        public async Task UpdateAsync(MessageContent content)
        {
            var str = new InteractionResponse(ResponseType.Update, new(content));

            await Callback(str.Serialize());
        }

        public async Task RespondAsync(MessageContent content)
        {
            var str = new InteractionResponse(ResponseType.Respond, new(content));

            await Callback(str.Serialize());
        }

        public Task FollowupAsync(MessageContent content)
        {
            throw new NotImplementedException();
        }
    }
}
