using System.Text;
using Crest.Verification;
using Model = Crest.Models.Interaction;

namespace Crest
{
    /// <summary>
    ///     An interaction from Discord.
    /// </summary>
    public abstract record Interaction : IInteraction
    {
        /// <inheritdoc/>
        public IClient Client { get; }

        /// <summary>
        ///     The ID of this interaction.
        /// </summary>
        public ulong Id { get; }

        /// <summary>
        ///     The ID of the app this interaction was executed for.
        /// </summary>
        public ulong ApplicationId { get; }

        /// <summary>
        ///     The exact time this interaction was executed on.
        /// </summary>
        public DateTimeOffset Timestamp { get; }
        
        /// <summary>
        ///     The response token of this interaction.
        /// </summary>
        public string Token { get; }

        /// <summary>
        ///     The callback to respond to this interaction.
        /// </summary>
        public Func<string, Task> Callback { get; }

        internal Interaction(Model model, Func<string, Task> callback, string timestamp, DiscordClient client)
        {
            Timestamp = SnowflakeConverter.ToTimestamp(timestamp);
            Id = model.Id;
            ApplicationId = model.AppId;
            Token = model.Token;
            Callback = callback;
            Client = client;
        }

        public static bool TryParse(DiscordClient client, string signature, string timestamp, string publicKey, byte[] body, Func<string, Task> callback, out Interaction interaction)
        {
            // transform key and signature to bytes
            var key = HexConverter.HexToByteArray(publicKey);
            var sig = HexConverter.HexToByteArray(signature);

            // transform timestamp and body to bytes
            var tsp = Encoding.UTF8.GetBytes(timestamp);

            // arrange message from timestamp & body
            var msg = new List<byte>();
            msg.AddRange(tsp);
            msg.AddRange(body);

            interaction = null!;

            if (IsValidInteraction(sig, msg.ToArray(), key))
            {
                var model = ModelConverter.FromJson<Model>(Encoding.UTF8.GetString(body));

                if (model is null)
                    return false;

                interaction = model.Type switch
                {
                    InteractionType.Ping => new PingInteraction(model, callback, timestamp, client),
                    InteractionType.Modal => new ModalInteraction(model, callback, timestamp, client),
                    InteractionType.MessageComponent => new ComponentInteraction(model, callback, timestamp, client),
                    InteractionType.ApplicationCommand => CommandInteraction.Parse(model, callback, timestamp, client),
                    _ => throw new NotImplementedException()
                };
            }
            return false;
        }

        private static bool IsValidInteraction(byte[] signature, byte[] message, byte[] key)
            => Ed25519.Verify(signature, message, key);
    }
}
