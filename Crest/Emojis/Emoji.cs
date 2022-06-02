using Crest.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Emojis
{
    public class Emoji
    {
        public ulong Id { get; set; }

        public string? Name { get; set; }

        public IReadOnlyCollection<ulong>? RoleIds { get; set; }

        public User? User { get; set; }

        public bool? RequiresColons { get; set; }

        public bool? Managed { get; set; }

        public bool? Animated { get; set; }

        public bool? Available { get; set; }
    }
}
