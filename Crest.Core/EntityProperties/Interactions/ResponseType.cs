using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest
{
    /// <summary>
    ///     https://discord.com/developers/docs/interactions/receiving-and-responding#interaction-response-object-interaction-callback-type
    /// </summary>
    public enum ResponseType
    {
        /// <summary>
        ///     PONG
        /// </summary>
        Pong = 1,

        /// <summary>
        ///     CHANNEL_MESSAGE_WITH_SOURCE
        /// </summary>
        Respond = 4,

        /// <summary>
        ///     DEFERRED_CHANNEL_MESSAGE_WITH_SOURCE
        /// </summary>
        Defer = 5,

        /// <summary>
        ///     DEFERRED_UPDATE_MESSAGE
        /// </summary>
        DeferUpdate = 6,

        /// <summary>
        ///     UPDATE_MESSAGE
        /// </summary>
        Update = 7,

        /// <summary>
        ///     APPLICATION_COMMAND_AUTOCOMPLETE_RESULT
        /// </summary>
        Autocomplete = 8,

        /// <summary>
        ///     MODAL
        /// </summary>
        Modal = 9,
    }
}
