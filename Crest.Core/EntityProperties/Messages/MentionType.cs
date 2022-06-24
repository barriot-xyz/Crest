namespace Crest
{
    public enum MentionType : int
    {
        /// <summary>
        ///     Mentions @everyone, no explicit roles or users.
        /// </summary>
        Everyone = 0,

        /// <summary>
        ///     Mentions only roles.
        /// </summary>
        Roles = 1,

        /// <summary>
        ///     Mentions only users.
        /// </summary>
        Users = 2,

        /// <summary>
        ///     Mentions @everyone, roles and users.
        /// </summary>
        All = 3,
    }
}
