namespace Crest
{
    public record GuildChannel : Channel
    {
        internal GuildChannel(Models.Channel model) : base(model)
        {
            
        }

        public static bool TryParse(string json, out GuildChannel entity)
        {
            var model = JsonConvert.DeserializeObject<Models.Channel>(json);

            if (model is not null)
            {
                entity = new(model);
                return true;
            }
            else
            {
                entity = null!;
                return false;
            }
        }

        public override string ToString()
            => $"<#{Id}>";
    }
}
