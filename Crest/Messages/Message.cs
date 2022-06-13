using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Messages
{
    public record Message : IEntity<ulong>
    {
        public ulong Id { get; set; }
    }
}
