using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest
{
    /// <summary>
    ///     https://discord.com/developers/docs/interactions/message-components#component-object-component-types
    /// </summary>
    public enum TextInputStyle
    {
        /// <summary>
        ///     Single line input
        /// </summary>
        Short = 1,

        /// <summary>
        ///     Multi-line input
        /// </summary>
        Paragraph = 2,
    }
}
