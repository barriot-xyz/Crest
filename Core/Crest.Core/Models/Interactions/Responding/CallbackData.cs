using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Models
{
    public class CallbackData
    {
        // Messages
        [JsonProperty("tts")]
        public bool? TTS { get; set; }

        [JsonProperty("content")]
        public string? Content { get; set; }

        [JsonProperty("embeds")]
        public Embed[]? Embeds { get; set; }

        [JsonProperty("allowed_mentions")]
        public AllowedMentions? AllowedMentions { get; set; }

        [JsonProperty("flags")]
        public MessageFlags? Flags { get; set; }

        // Modals / Messages
        [JsonProperty("components")]
        public ActionRow[]? Components { get; set; }

        // Autocompletion
        [JsonProperty("choices")]
        public ApplicationCommandOptionChoice[] Choices { get; set; }

        // Modals
        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        ///     Create callback data for a deferral.
        /// </summary>
        /// <param name="ephemeral"></param>
        public CallbackData(bool ephemeral)
        {

        }

        /// <summary>
        ///     Create callback data for a modal.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="cid"></param>
        public CallbackData(string title, string cid, IComponent[] components)
        {
            Components = ActionRow.CreateModalRange(components).ToArray();
            Title = title;
            CustomId = cid;
        }
    }
}
