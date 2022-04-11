using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Entities
{
    public interface IEntity
    {
        /// <summary>
        ///     Represents the ID of this resource.
        /// </summary>
        public ulong Id { get; }
    }
}
