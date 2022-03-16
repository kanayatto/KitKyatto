using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Logging;
using Discord.Net.Converters;
using Discord.Rest;
using Discord.WebSocket;

namespace KitKyatto
{
    internal class Discord_Client_Stuffs
    {
        private DiscordSocketClient client;
        public async Task Main()
        {
            client = new DiscordSocketClient();
            client.MessageReceived += Commands;

            string token = "OTQyMTYyOTkxOTU5NDA0NTc0.YggfqQ.hCgfgBWUV8YIWUsiSZZ7BC7Mxu8";

            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            await Task.Delay(-1);
        }

        public Task Commands(SocketMessage message)
        {
            if (message.Content == "uwu")
            {
                string extra = message.Content.Split(new[] {"uwu"}, StringSplitOptions.None)[1];
                var avatar = message.Author.GetAvatarUrl();
                EmbedBuilder uwu = new EmbedBuilder();
                uwu.Title = "GitHub Statistics";
                uwu.ImageUrl = @"https://github-readme-stats.vercel.app/api?username=" + extra + "&show_icons=true&theme=nord";
            }



            return Task.CompletedTask;
        }
    }
}
