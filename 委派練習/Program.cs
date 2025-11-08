using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 委派練習
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 思考如何解決排列組合下的耦合問題(類別與類別之間不可以有任何相依性)
            // Tips:嘗試建立多個不同的 EventHandler來解決排列組合問題
            // 請使用random 建立隨機事件
            // 委派:Action/Func/EventHandler/delegate
            // EventHandler(事件接收器/一邊做接收事件通知/另一邊事件處理)
            // 無法在附近就連絡到  => SayHello => FindPerson => ContactPerson
            // 可以直接在附近就聯絡 =>  => SayHello  => ContactPerson
            // 即使擴大搜索也無法找到人 =>  => SayHello => FindPerson
            MessageHandler.ExpandSearchHandler += Expand;
            MessageHandler.FoundMessageHandler += Found;
            MessageHandler.NotFoundMessageHandler += NotFound;
            SayHello sayHello = new SayHello();
            sayHello.SayHi("Leo");

        }
        private static void Found(object sender, string e)
        {
            ContactPerson contactPerson = new ContactPerson();
            contactPerson.Contact(e);
            Console.WriteLine(e);
        }
        private static void NotFound(object sender, string e)
        {
            Console.WriteLine(e);
        }
        private static void Expand(object sender, string e)
        {
            FindPerson findPerson = new FindPerson();
            findPerson.Find(e);
        }

    }
}
