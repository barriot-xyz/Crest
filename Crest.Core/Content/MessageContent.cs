using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest
{
    /// <summary>
    ///     Represents a class that holds the content of a message to be sent.
    /// </summary>
    public class MessageContent
    {
        /// <summary>
        ///     The text held by this message.
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        ///     The flags to apply to this message.
        /// </summary>
        public MessageFlags? Flags { get; set; }

        /// <summary>
        ///     The mentioning permissions of this message.
        /// </summary>
        public AllowedMentions? AllowedMentions { get; set; }

        /// <summary>
        ///     The range of embeds to use for this message.
        /// </summary>
        public Embed[]? Embeds { get; set; }

        /// <summary>
        ///     The range of components to attach to this message.
        /// </summary>
        public Components? Components { get; set; }
    }
}
