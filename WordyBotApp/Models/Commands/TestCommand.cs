using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace WordyBotApp.Models.Commands
{
    public class TestCommand : Command
    {
        public override string Name => "/test";

        public override async void Execute(Telegram.Bot.Types.Message message, TelegramBotClient botClient)
        {
            long chatId = message.Chat.Id;
            string incomingMessage = message.Text;
            await botClient.SendTextMessageAsync(chatId, incomingMessage);
        }
    }
}
