using Model = Crest.Models.Channel;

namespace Crest
{
    public record Message : IMessage
    {
        public IClient Client { get; }

        public ulong Id { get; set; }

        public Message(Model model, DiscordClient client)
        {
            Client = client;
            Id = model.Id;
        }
    }
}
