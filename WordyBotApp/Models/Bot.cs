using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using WordyBotApp.Models.Commands;

namespace WordyBotApp.Models
{
    public static class Bot
    {
        private static TelegramBotClient botClient;
        private static List<Command> commandsList;
        public static IReadOnlyCollection<Command> Commands { get => commandsList.AsReadOnly(); }

        public static async Task<TelegramBotClient> Get()
        {
            if(botClient != null)
            {
                return botClient;
            }
            commandsList = new List<Command>();
            commandsList.Add(new TestCommand());
            //Add new commands here

            botClient = new TelegramBotClient(AppSettings.Token);
            var hook = string.Format(AppSettings.Url, "api/MessageController");
            await botClient.SetWebhookAsync(hook);

            return botClient;
        }
    }
}
