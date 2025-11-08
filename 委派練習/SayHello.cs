using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 委派練習
{
    internal class SayHello
    {
        public void SayHi(string name)
        {

            Random random = new Random();
            int number = random.Next(0, 101);
            if (number >= 80)
            {
                MessageHandler.FoundNotify($"直接找到{name},Hi,{name}最近過得好嗎?");
            }
            else
            {
                Console.WriteLine($"目前{name}不在聯絡範圍內···正在擴大搜索中···");
                MessageHandler.ExpandSearchNotify(name);
            }

        }
    }
}
