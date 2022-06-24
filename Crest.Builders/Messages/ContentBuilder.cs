using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Builders
{
    /// <summary>
    ///     Represents a builder for <see cref="MessageContent"/>.
    /// </summary>
    public class ContentBuilder : IBuilder<MessageContent>
    {
        /// <summary>
        ///     The range of embeds that have been attached in this builder.
        /// </summary>
        public List<Embed> Embeds { get; private set; }

        /// <summary>
        ///     The components that have been attached to this builder.
        /// </summary>
        public Components? Components { get; private set; }

        /// <summary>
        ///     The text content for this builder.
        /// </summary>
        public string? Text { get; private set; }

        /// <summary>
        ///     The mention permissions for this builder.
        /// </summary>
        public AllowedMentions? AllowedMentions { get; private set; }

        /// <summary>
        ///     The message flags for this builder.
        /// </summary>
        public MessageFlags? Flags { get; private set; }

        public ContentBuilder()
        {
            Embeds = new();
        }

        /// <summary>
        ///     Sets the <see cref="Text"/> of this builder. Overrides old entry.
        /// </summary>
        /// <remarks>
        ///     This method is overridable to modify the workflow of the builder.
        /// </remarks>
        /// <returns></returns>
        public virtual ContentBuilder WithText(string text)
        {
            Text = text;
            return this;
        }

        /// <summary>
        ///     Sets the <see cref="Text"/> of this builder. Overrides old entry.
        /// </summary>
        /// <remarks>
        ///     This method is overridable to modify the workflow of the builder.
        /// </remarks>
        /// <returns></returns>
        public virtual ContentBuilder WithText(TextBuilder builder)
        {
            Text = builder.Build();
            return this;
        }

        /// <summary>
        ///     TODO
        /// </summary>
        /// <remarks>
        ///     This method is overridable to modify the workflow of the builder.
        /// </remarks>
        /// <returns></returns>
        public virtual ContentBuilder WithFile(string fileName)
        {
            return this;
        }

        /// <summary>
        ///     Sets the <see cref="AllowedMentions"/> of this builder. Overrides old entry.
        /// </summary>
        /// <remarks>
        ///     This method is overridable to modify the workflow of the builder.
        /// </remarks>
        /// <returns></returns>
        public virtual ContentBuilder WithMentionPermissions(AllowedMentionsBuilder builder)
        {
            AllowedMentions = builder.Build();
            return this;
        }

        /// <summary>
        ///     Sets the <see cref="Flags"/> of this builder. Overrides old entries.
        /// </summary>
        /// <remarks>
        ///     This method is overridable to modify the workflow of the builder.
        /// </remarks>
        /// <returns></returns>
        public virtual ContentBuilder WithFlags(params MessageFlags[] flags)
        {
            foreach(var flag in flags)
            {
                if (Flags is not null)
                    Flags |= flag;
                else
                    Flags = flag;
            }
            return this;
        }

        /// <summary>
        ///     Sets the <see cref="Embeds"/> of this builder. Overrides old entries.
        /// </summary>
        /// <remarks>
        ///     This method is overridable to modify the workflow of the builder.
        /// </remarks>
        /// <returns></returns>
        public virtual ContentBuilder WithEmbeds(MultiEmbedBuilder builder)
        {
            Embeds = builder.Build().ToList();
            return this;
        }

        /// <summary>
        ///     Adds an <see cref="Embed"/> to the builder.
        /// </summary>
        /// <remarks>
        ///     This method is overridable to modify the workflow of the builder.
        /// </remarks>
        /// <returns></returns>
        public virtual ContentBuilder AddEmbed(EmbedBuilder builder)
        {
            if (Embeds.Count is 10)
                throw new ArgumentOutOfRangeException(nameof(builder), "A max of 10 embeds are to be attached to a message.");

            Embeds.Add(builder.Build());
            return this;
        }

        /// <summary>
        ///     
        /// </summary>
        /// <remarks>
        ///     This method is overridable to modify the workflow of the builder.
        /// </remarks>
        /// <returns></returns>
        public virtual ContentBuilder WithComponents(ComponentBuilder builder)
        {
            Components = builder.Build();
            return this;
        }

        /// <summary>
        ///     Builds the current builder into an instance of <see cref="MessageContent"/>.
        /// </summary>
        /// <remarks>
        ///     This method is overridable to modify the workflow of the builder.
        /// </remarks>
        /// <returns></returns>
        public virtual MessageContent Build()
        {
            return new MessageContent()
            {
                Text = Text,
                AllowedMentions = AllowedMentions,
                Flags = Flags,
                Embeds = Embeds.ToArray(),
                Components = Components
            };
        }
    }
}
