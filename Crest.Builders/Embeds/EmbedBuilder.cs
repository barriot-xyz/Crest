namespace Crest.Builders
{
    public class EmbedBuilder : IBuilder<Embed>
    {
        public List<EmbedField> Fields { get; private set; }

        public string? Title { get; private set; }

        public string? TitleUrl { get; private set; }

        public string? Description { get; private set; }

        public string? Footer { get; private set; }

        public string? FooterIconUrl { get; private set; }

        public string? Author { get; private set; }

        public string? AuthorUrl { get; private set; }

        public string? AuthorIconUrl { get; private set; }

        public string? ThumbnailUrl { get; private set; }

        public string? ImageUrl { get; private set; }

        public EmbedBuilder()
        {
            Fields = new();
        }

        public EmbedBuilder WithTitle(string title)
        {

        }

        public EmbedBuilder WithDescription(string description)
        {

        }

        public EmbedBuilder WithTitleUrl(string url)
        {

        }

        public EmbedBuilder WithAuthor(EmbedAuthorBuilder builder)
        {

        }

        public EmbedBuilder WithFooter(EmbedFooterBuilder builder)
        {

        }

        public EmbedBuilder WithThumbnailUrl(string url)
        {

        }

        public EmbedBuilder WithImageUrl(string url)
        {

        }

        public EmbedBuilder WithFields(params EmbedFieldBuilder[] builders)
        {
            Fields.Clear();

            if (builders.Length is > 25)
                throw new ArgumentOutOfRangeException(nameof(builders), "A max of 25 fields are to be attached to an embed.");
            foreach(var builder in builders)
            {
                Fields.Add(builder.Build());
            }
        }

        public Embed Build()
        {
            throw new NotImplementedException();
        }
    }
}
