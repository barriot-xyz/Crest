using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions.Properties
{
    /// <summary>
    ///     https://discord.com/developers/docs/interactions/receiving-and-responding#interaction-object-interaction-type
    /// </summary>
    internal enum InteractionType
    {
        /// <summary>
        ///     PING
        /// </summary>
        Ping = 1,

        /// <summary>
        ///     APPLICATION_COMMAND
        /// </summary>
        ApplicationCommand = 2,

        /// <summary>
        ///     MESSAGE_COMPONENT
        /// </summary>
        MessageComponent = 3,

        /// <summary>
        ///     APPLICATION_COMMAND_AUTOCOMPLETE
        /// </summary>
        AutoComplete = 4,

        /// <summary>
        ///     MODAL_SUBMIT
        /// </summary>
        Modal = 5,
    }
}
