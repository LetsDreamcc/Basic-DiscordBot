using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Discordbot.Module
{
    public class commands : ModuleBase<SocketCommandContext>
    {
        [Command("command")]
        public async Task command()
        {
            await ReplyAsync("Message");
            Console.WriteLine(DateTime.Now + " Requested: -command");
        }
    }
}
