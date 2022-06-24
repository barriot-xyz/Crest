using Crest.Models;
using Model = Crest.Models.Interaction;

namespace Crest
{
    public record SlashCommand : CommandInteraction
    {
        internal SlashCommand(Model model, Func<string, Task> callback, string timestamp, DiscordClient client) 
            : base(model, callback, timestamp, client)
        {
        }

        public override async Task DeferAsync(bool doEphemeral)
        {
            var str = new InteractionResponse(ResponseType.Defer, new CallbackData(doEphemeral, false));
            await Callback(str.Serialize());
        }

        public override Task FollowupAsync(MessageContent content)
        {
            throw new NotImplementedException();
        }

        public override async Task RespondAsync(MessageContent content)
        {
            var str = new InteractionResponse(ResponseType.Respond, new(content));

            await Callback(str.Serialize());
        }
    }
}
