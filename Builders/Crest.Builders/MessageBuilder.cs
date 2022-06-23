using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Builders
{
    internal class MessageBuilder : IEntityBuilder<IMessage>
    {
        public MessageBuilder()
        {

        }

        public MessageBuilder WithContent(string content)
        {
            return this;
        }

        public MessageBuilder WithFile(string fileName)
        {
            return this;
        }

        public MessageBuilder WithEmbeds()
        {
            return this;
        }

        public MessageBuilder WithComponents()
        {
            return this;
        }

        public IMessage Build()
        {
            throw new NotImplementedException();
        }
    }
}
