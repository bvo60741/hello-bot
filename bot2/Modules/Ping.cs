using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace bot2.Modules
{
    
    public class Ping : ModuleBase<SocketCommandContext>
    {
        //private SocketGuildUser user;
        [Command("hi")]
        public async Task PingAsync(SocketGuildUser user)
        {
            //user = new SocketGuildUser()
            await ReplyAsync("Hello " + user.Mention + "! :wave:");
        }
    }
}