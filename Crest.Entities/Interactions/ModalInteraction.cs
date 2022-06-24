using Crest.Models;
using Model = Crest.Models.Interaction;

namespace Crest
{
    public record ModalInteraction : Interaction, IClientInteraction
    {
        internal ModalInteraction(Model model, Func<string, Task> callback, string timestamp, DiscordClient client) 
            : base(model, callback, timestamp, client)
        {
        }

        public Task DeferAsync(bool doEphemeral)
        {
            throw new NotImplementedException();
        }

        public Task FollowupAsync(MessageContent content)
        {
            throw new NotImplementedException();
        }

        public Task RespondAsync(MessageContent content)
        {
            var cb = new CallbackData()
            {
                Content = content.Text,
                Flags = content.Flags,
            };
        }
    }
}
