using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace bot2.Modules
{
    public class PingRus : ModuleBase<SocketCommandContext>
    {
        [Command("привет")]
        public async Task PingAsync()
        {
           // IGuildUser guildUser;
            await ReplyAsync("Привет всем! @here :wave:");
        }
    }
}