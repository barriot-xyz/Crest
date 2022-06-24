namespace Crest
{
    public record PartialUser : IUser
    {
        public IClient Client { get; }

        public ulong Id { get; }

        internal PartialUser(Models.User model, DiscordClient client)
        {
            Client = client;
            Id = model.Id;
        }
    }
}
