using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Discord_Bot.Modules
{
    public class commands : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        public async Task proccedHelp()
        {
            await Task.Delay(-1);
        }
    }
}
