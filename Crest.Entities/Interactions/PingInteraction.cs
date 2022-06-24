using Crest.Models;
using Model = Crest.Models.Interaction;

namespace Crest
{
    public record PingInteraction : Interaction
    {
        internal PingInteraction(Model model, Func<string, Task> callback, string timestamp, DiscordClient client) 
            : base(model, callback, timestamp, client)
        {

        }

        public async Task AcknowledgeAsync()
        {
            var response = new InteractionResponse(ResponseType.Pong).Serialize();

            await Callback(response);
        }
    }
}
