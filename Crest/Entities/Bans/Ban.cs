using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model = Crest.Api.Json.BanModel;

namespace Crest.Entities.Bans
{
    public class Ban : IEntity<ulong>
    {
        public ulong Id { get; }

        internal Ban(Model model)
        {
            Id = model.Id;
        }

        public override string ToString()
            => $"<@{Id}>";

        public async Task<bool> DeleteAsync()
            => 
    }
}
