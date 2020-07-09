using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordyBotApp.Models
{
    public static class AppSettings
    {
        public static string Name { get; private set; }

        public static string Token { get; private set; }

        public static string Url { get; private set; }
    }
}
