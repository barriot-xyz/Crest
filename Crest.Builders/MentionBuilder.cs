using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Builders
{
    /// <summary>
    ///     Represents a builder for <see cref="AllowedMentions"/> for messages.
    /// </summary>
    public class MentionBuilder : IBuilder<AllowedMentions>
    {
        private bool _canMentionInReply;
        private MentionType[] _types;
        private List<ulong> _allowedUsers;
        private List<ulong> _allowedRoles;

        public MentionBuilder()
        {
            _canMentionInReply = false;
            _types = Array.Empty<MentionType>();
            _allowedUsers = new();
            _allowedRoles = new();
        }

        /// <summary>
        ///     Sets the allowed types to be mentioned.
        /// </summary>
        /// <param name="types"></param>
        /// <returns></returns>
        public MentionBuilder WithAllowedTypes(params MentionType[] types)
        {
            _types = types;
            return this;
        }

        /// <summary>
        ///     Sets if the user that's being replied to (if available) is allowed to be mentioned in the reply.
        /// </summary>
        /// <param name="allowMentionInReply"></param>
        /// <returns></returns>
        public MentionBuilder WithAllowReply(bool allowMentionInReply)
        {
            _canMentionInReply = allowMentionInReply;
            return this;
        }

        /// <summary>
        ///     Sets a range of users that are allowed to be pinged. This method does not need to be called if all users are allowed to be mentioned.
        /// </summary>
        /// <param name="userIds"></param>
        /// <returns></returns>
        public MentionBuilder WithUsers(params ulong[] userIds)
        {
            _allowedUsers = userIds.ToList();
            return this;
        }

        /// <summary>
        ///     Sets a range of roles that are allowed to be pinged. This method does not need to be called if all roles are allowed to be mentioned.
        /// </summary>
        /// <param name="roleIds"></param>
        /// <returns></returns>
        public MentionBuilder WithRoles(params ulong[] roleIds)
        {
            _allowedRoles = roleIds.ToList();
            return this;
        }

        /// <summary>
        ///     Adds a user to the range of users that is allowed to be pinged. Please refer to the documentation of <see cref="WithUsers(ulong[])"/> for use cases.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public MentionBuilder AddUser(ulong userId)
        {
            _allowedUsers.Add(userId);
            return this;
        }

        /// <summary>
        ///     Adds a user to the range of users that is allowed to be pinged. Please refer to the documentation of <see cref="WithRoles(ulong[])"/> for use cases.
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public MentionBuilder AddRole(ulong roleId)
        {
            _allowedRoles.Add(roleId);
            return this;
        }

        /// <inheritdoc />
        public AllowedMentions Build()
        {
            return new AllowedMentions()
            {
                MentionTypes = ConvertTypesToParse().ToArray(),
                AllowMentionReply = _canMentionInReply,
                UserIds = _allowedUsers.ToArray(),
                RoleIds = _allowedRoles.ToArray()
            };
        }

        private IEnumerable<string> ConvertTypesToParse()
        {
            foreach(var type in _types)
            {
                switch (type)
                {
                    case MentionType.Everyone:
                        yield return "everyone";
                        continue;
                    case MentionType.Roles:
                        yield return "roles";
                        continue;
                    case MentionType.Users:
                        yield return "users";
                        continue;
                }
            }
        }
    }
}
