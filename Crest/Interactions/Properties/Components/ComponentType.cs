using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions.Properties.Components
{
    /// <summary>
    ///     https://discord.com/developers/docs/interactions/message-components#component-object-component-types
    /// </summary>
    internal enum ComponentType
    {
        /// <summary>
        ///     Action Row
        /// </summary>
        ActionRow = 1,

        /// <summary>
        ///     Button
        /// </summary>
        Button = 2,

        /// <summary>
        ///     Select Menu
        /// </summary>
        SelectMenu = 3,

        /// <summary>
        ///     Text input
        /// </summary>
        TextInput = 4,
    }
}
