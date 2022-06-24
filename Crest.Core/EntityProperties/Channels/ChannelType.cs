using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest
{
    /// <summary>
    ///     https://discord.com/developers/docs/resources/channel#channel-object-channel-types
    /// </summary>
    public enum ChannelType
    {
        /// <summary>
        ///     GUILD_TEXT
        /// </summary>
        Text = 0,

        /// <summary>
        ///     DM
        /// </summary>
        DM = 1,

        /// <summary>
        ///     GUILD_VOICE
        /// </summary>
        Voice = 2,

        /// <summary>
        ///     GROUP_DM
        /// </summary>
        Group = 3,

        /// <summary>
        ///     GUILD_CATEGORY
        /// </summary>
        Category = 4,

        /// <summary>
        ///     GUILD_NEWS
        /// </summary>
        News = 5,

        /// <summary>
        ///     GUILD_NEWS_THREAD
        /// </summary>
        NewsThread = 10,

        /// <summary>
        ///     GUILD_PUBLIC_THREAD
        /// </summary>
        PublicThread = 11,

        /// <summary>
        ///     GUILD_PRIVATE_THREAD
        /// </summary>
        PrivateThread = 12,

        /// <summary>
        ///     GUILD_STAGE_VOICE
        /// </summary>
        Stage = 13,

        /// <summary>
        ///     GUILD_DIRECTORY
        /// </summary>
        Directory = 14,

        /// <summary>
        ///     GUILD_FORUM
        /// </summary>
        Forum = 15
    }
}
