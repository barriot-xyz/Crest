using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Builders
{
    internal interface IBuilder<T>
    {
        /// <summary>
        ///     Builds the current builder into an instance of <typeparamref name="T"/>.
        /// </summary>
        /// <returns></returns>
        public T Build();
    }
}
