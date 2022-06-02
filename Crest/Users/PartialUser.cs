using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Users
{
    public record PartialUser : IEntity<ulong>
    {
        public ulong Id { get; }

        internal PartialUser(Models.User model)
        {
            Id = model.Id;
        }
    }
}
