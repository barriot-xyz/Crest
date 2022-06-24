using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Builders
{
    public class EmbedFieldBuilder : IBuilder<EmbedField>
    {
        public string Title { get; private set; }

        public string Value { get; private set; }

        public bool IsInline { get; private set; }

        public EmbedField Build()
        {
            throw new NotImplementedException();
        }
    }
}
