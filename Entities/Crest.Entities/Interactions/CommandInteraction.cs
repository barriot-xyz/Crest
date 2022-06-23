using Model = Crest.Models.Interaction;

namespace Crest
{
    public abstract record CommandInteraction : Interaction, IClientInteraction
    {
        internal CommandInteraction(Model model, Func<string, Task> callback, string timestamp, DiscordClient client) : base(model, callback, timestamp, client)
        {

        }

        internal static CommandInteraction Parse(Model model, Func<string, Task> callback, string timestamp, DiscordClient client)
        {
            if (model.Data is not null)
            {
                return model.Data.Type switch
                {
                    ApplicationCommandType.Message => new MessageCommand(model, callback, timestamp, client),
                    ApplicationCommandType.User => new UserCommand(model, callback, timestamp, client),
                    ApplicationCommandType.Slash => new SlashCommand(model, callback, timestamp, client),
                    _ => throw new NotImplementedException()
                };
            }
            throw new InvalidOperationException();
        }

        public abstract Task DeferAsync(bool doEphemeral);

        public abstract Task FollowupAsync();

        public abstract Task RespondAsync();
    }
}
