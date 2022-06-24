namespace Crest
{
    /// <summary>
    ///     Represents action flags for messages.
    /// </summary>
    [Flags]
    public enum MessageFlags : int
    {
        /// <summary>
        ///     This message has been published to subscribed channels (via Channel Following).
        /// </summary>
        IsCrossPosted = 1 << 0,

        /// <summary>
        ///     This message originated from a message in another channel (via Channel Following).
        /// </summary>
        IsCrossPost = 1 << 1,

        /// <summary>
        ///     Do not include any embeds when serializing this message.
        /// </summary>
        EmbedsSupressed = 1 << 2,

        /// <summary>
        ///     The source message for this crosspost has been deleted (via Channel Following).
        /// </summary>
        SourceDeleted = 1 << 3,

        /// <summary>
        ///     This message came from the urgent message system.
        /// </summary>
        Urgent = 1 << 4,

        /// <summary>
        ///     This message has an associated thread, with the same id as the message.
        /// </summary>
        HasThread = 1 << 5,

        /// <summary>
        ///     This message is only visible to the user who invoked the Interaction.
        /// </summary>
        IsEphemeral = 1 << 6,

        /// <summary>
        ///     This message is an Interaction Response and the bot is "thinking".
        /// </summary>
        IsLoading = 1 << 7,

        /// <summary>
        ///     This message failed to mention some roles and add their members to the thread.
        /// </summary>
        ThreadMentionsFailed = 1 << 8,
    }
}
