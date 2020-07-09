using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordyBotApp.Models.Commands
{
    public abstract class Command
    {
        public abstract string Name { get; set; }

        public abstract void Execute();
    }
}
