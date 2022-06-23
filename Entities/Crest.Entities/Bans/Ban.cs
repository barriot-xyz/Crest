using Model = Crest.Models.Ban;

namespace Crest
{
    public class Ban : IBan
    {
        public IClient Client { get; }

        public ulong Id { get; }

        internal Ban(Model model)
        {
            Id = model.Id;
        }

        public override string ToString()
            => $"<@{Id}>";
    }
}
