using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest
{
    public record Role : IRole
    {
        public IClient Client { get; }

        public ulong Id { get; }
    }
}
