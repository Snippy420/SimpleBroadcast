using OpenMod.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Color = System.Drawing.Color;

namespace SimpleBroadcast.Commands
{
    [Command("broadcast")]
    [CommandAlias("bc")]
    [CommandDescription("Broadcast to all players on the sevrer")]
    [CommandSyntax("<message>")]
    public class Broadcast : Command
    {
        public Broadcast(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        protected override async Task OnExecuteAsync()
        {
            var message = await Context.Parameters.GetAsync<string>(0);

            await PrintAsync(message, Color.Lime);
        }
    }
}
