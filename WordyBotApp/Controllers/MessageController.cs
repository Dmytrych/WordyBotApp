using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;
using WordyBotApp.Models;

namespace WordyBotApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        public async Task<OkResult> Update([FromBody]Update update)
        {
            var botCommands = Bot.Commands;
            var recievedMessage = update.Message;
            var botClient = await Bot.Get();


            foreach(var command in botCommands)
            {
                if (command.ContainsIn(recievedMessage.Text))
                {
                    command.Execute(recievedMessage, botClient);
                    break;
                }
            }
            return Ok();
        }
    }
}