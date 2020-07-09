using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace WordyBotApp.Models
{
    public static class Bot
    {
        private static TelegramBotClient botClient;

        public static async Task<TelegramBotClient> Get()
        {
            if(botClient == null)
            {
                botClient = new TelegramBotClient(AppSettings.Token);
                await botClient.SetWebhookAsync(AppSettings.Url);
            }

            return botClient;
        }
    }
}
