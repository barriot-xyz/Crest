using Crest.Interactions.Properties.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crest.Interactions
{
    public abstract record Command : Interaction
    {
        internal Command(Models.Interaction model, Func<string, Task> callback, string timestamp) : base(model, callback, timestamp)
        {
        }

        internal static Command Parse(Models.Interaction model, Func<string, Task> callback, string timestamp)
        {
            if (model.Data is not null)
            {
                return model.Data.Type switch
                {
                    ApplicationCommandType.Message => new MessageCommand(model, callback, timestamp),
                    ApplicationCommandType.User => new UserCommand(model, callback, timestamp),
                    ApplicationCommandType.Slash => new SlashCommand(model, callback, timestamp),
                    _ => throw new NotImplementedException()
                };
            }
            throw new InvalidOperationException();
        }
    }
}
