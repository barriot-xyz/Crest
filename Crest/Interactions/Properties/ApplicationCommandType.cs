using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions.Properties
{
    /// <summary>
    ///     https://discord.com/developers/docs/interactions/application-commands#application-command-object-application-command-structure
    /// </summary>
    internal enum ApplicationCommandType
    {
        /// <summary>
        ///     CHAT_INPUT
        /// </summary>
        Slash = 1,

        /// <summary>
        ///     USER
        /// </summary>
        User = 2,

        /// <summary>
        ///     MESSAGE
        /// </summary>
        Message = 3,
    }
}
