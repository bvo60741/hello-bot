using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace bot2.Modules
{
    public class help : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        public async Task PingAsync()
        {
            await ReplyAsync("**Вот что я умею:** _!hi_ - передать всем привет на английском, _!привет_ - передать всем привет на русском");
        }
    }
}