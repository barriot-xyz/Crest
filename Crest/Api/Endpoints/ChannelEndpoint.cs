using Crest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Api.Endpoints
{
    public class ChannelEndpoint
    {
        private readonly CrestHttpManager _manager;

        public ChannelEndpoint(CrestHttpManager manager)
        {
            _manager = manager;
        }

        public async Task<Channel> GetOneAsync(ulong id)
        {
            var result = await _manager.SendAsync(new(HttpMethod.Get, $"channels/{id}"));

            if (Channel.TryParse(await result.GetJsonAsync(), out var channel))
                return channel;
            else
                throw new ArgumentNullException(nameof(channel));
        }
    }
}
