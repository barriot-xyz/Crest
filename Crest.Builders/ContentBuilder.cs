using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Builders
{
    public class ContentBuilder : IBuilder<MessageContent>
    {
        private AllowedMentions? _allowedMentions;
        private string? _content;
        private MessageFlags? _flags;

        public ContentBuilder()
        {

        }

        public virtual ContentBuilder WithText(string text)
        {
            _content = text;
            return this;
        }

        public virtual ContentBuilder WithFile(string fileName)
        {
            return this;
        }

        public virtual ContentBuilder WithMentionPermissions(MentionBuilder builder)
        {
            _allowedMentions = builder.Build();
            return this;
        }

        public virtual ContentBuilder WithFlags(params MessageFlags[] flags)
        {
            foreach(var flag in flags)
            {
                if (_flags is not null)
                    _flags |= flag;
                else
                    _flags = flag;
            }
            return this;
        }

        public virtual ContentBuilder WithEmbeds()
        {
            return this;
        }

        public virtual ContentBuilder WithComponents()
        {
            return this;
        }

        public virtual MessageContent Build()
        {
            return new MessageContent()
            {
                Text = _content,
                AllowedMentions = _allowedMentions,
                Flags = _flags,
            };
        }
    }
}
