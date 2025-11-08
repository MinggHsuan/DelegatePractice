using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派練習
{
    internal class MessageHandler
    {
        public static EventHandler<string> FoundMessageHandler;
        public static EventHandler<string> ExpandSearchHandler;
        public static EventHandler<string> NotFoundMessageHandler;

        public static void NotFoundNotify(string message)
        {
            NotFoundMessageHandler?.Invoke(null, message);
        }
        public static void FoundNotify(string message)
        {
            FoundMessageHandler?.Invoke(null, message);
        }
        public static void ExpandSearchNotify(string message)
        {
            ExpandSearchHandler?.Invoke(null, message);
        }
    }
}
