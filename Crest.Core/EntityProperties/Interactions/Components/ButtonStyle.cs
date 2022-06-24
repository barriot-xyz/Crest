using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest
{
    /// <summary>
    ///     https://discord.com/developers/docs/interactions/message-components#button-object-button-styles
    /// </summary>
    public enum ButtonStyle
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
