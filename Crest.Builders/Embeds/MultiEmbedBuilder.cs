using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Builders
{
    public class MultiEmbedBuilder : IBuilder<IEnumerable<Embed>>
    {
        private readonly List<EmbedBuilder> _builders;

        public MultiEmbedBuilder()
        {
            _builders = new();
        }

        public virtual MultiEmbedBuilder AddEmbed(EmbedBuilder builder)
        {
            if (_builders.Count is 10)
                throw new ArgumentOutOfRangeException(nameof(builder), "A max of 10 embeds are to be attached to a message.");
            _builders.Add(builder);
            return this;
        }

        public virtual MultiEmbedBuilder WithEmbeds(params EmbedBuilder[] builders)
        {
            if (builders.Length is > 10)
                throw new ArgumentOutOfRangeException(nameof(builders), "A max of 10 embeds are to be attached to a message.");

            _builders.Clear();
            _builders.AddRange(builders);
            return this;
        }

        public virtual IEnumerable<Embed> Build()
        {
            foreach(var builder in _builders)
            {
                yield return builder.Build();
            }
        }
    }
}
