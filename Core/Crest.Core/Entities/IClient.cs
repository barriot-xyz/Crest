using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest
{
    public interface IClient
    {
        public Task<bool> ConfigureAsync(AuthorizationType type, string token);
    }
}
