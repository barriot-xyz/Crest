using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crest.Converters;
using Crest.Verification;
using Crest.Interactions.Properties;
using Crest.Interactions.Properties.Commands;

namespace Crest.Interactions
{
    public abstract record Interaction : IEntity<ulong>
    {
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

        internal Interaction(Models.Interaction model, string timestamp)
        {
            Timestamp = SnowflakeConverter.ToTimestamp(timestamp);
            Id = model.Id;
            ApplicationId = model.AppId;
        }

        public static bool TryParse(string signature, string timestamp, string publicKey, byte[] body, out Interaction interaction)
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
                var model = ModelConverter.FromJson<Models.Interaction>(Encoding.UTF8.GetString(body));

                if (model is null)
                    return false;

                interaction = model.Type switch
                {
                    InteractionType.Ping => new PingInteraction(model, timestamp),
                    InteractionType.Modal => new ModalInteraction(model, timestamp),
                    InteractionType.MessageComponent => new ComponentInteraction(model, timestamp),
                    InteractionType.ApplicationCommand => Command.Parse(model, timestamp),
                    _ => throw new NotImplementedException()
                };
            }
            return false;
        }

        public static Interaction Parse(string signature, string timestamp, string publicKey, byte[] body)
        {
            if (!TryParse(signature, timestamp, publicKey, body, out var interaction))
                throw new InvalidOperationException("Unable to parse http interaction.");

            return interaction;
        }

        private static bool IsValidInteraction(byte[] signature, byte[] message, byte[] key)
            => Ed25519.Verify(signature, message, key);
    }
}
