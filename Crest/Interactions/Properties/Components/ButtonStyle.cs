using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions.Properties.Components
{
    /// <summary>
    ///     https://discord.com/developers/docs/interactions/message-components#button-object-button-styles
    /// </summary>
    internal enum ButtonStyle
    {
        /// <summary>
        ///     Primary
        /// </summary>
        Primary = 1,

        /// <summary>
        ///     Secondary
        /// </summary>
        Secondary = 2,

        /// <summary>
        ///     Success
        /// </summary>
        Success = 3,

        /// <summary>
        ///     Danger
        /// </summary>
        Danger = 4,

        /// <summary>
        ///     Link
        /// </summary>
        Link = 5,
    }
}
