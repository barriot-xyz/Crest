using Crest.Interactions.Properties.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions
{
    public class Command : Interaction
    {
        internal Command(Models.Interaction model, string timestamp) : base(model, timestamp)
        {
        }

        internal static Command Parse(Models.Interaction model, string timestamp)
        {
            if (model.Data is not null)
            {
                return model.Data.Type switch
                {
                    ApplicationCommandType.Message => new MessageCommand(model, timestamp),
                    ApplicationCommandType.User => new UserCommand(model, timestamp),
                    ApplicationCommandType.Slash => new SlashCommand(model, timestamp),
                    _ => throw new NotImplementedException()
                };
            }
            throw new InvalidOperationException();
        }
    }
}
