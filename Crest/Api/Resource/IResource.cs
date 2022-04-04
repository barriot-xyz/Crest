using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Api.Resources
{
    public interface IResource
    {
        /// <summary>
        ///     Represents the route of this resource.
        /// </summary>
        public string Route { get; }
    }
}
