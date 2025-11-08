using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 委派練習
{
    internal class FindPerson
    {
        public void Find(string name)
        {
            Random random = new Random();
            int number = random.Next(0, 101);
            if (number >= 30)
            {
                Console.WriteLine("搜索中···請稍後···");
                Thread.Sleep(3000);
                MessageHandler.FoundNotify($"Hi,{name}最近過得好嗎?");
            }
            else
            {
                MessageHandler.NotFoundNotify($"無法聯絡到{name}");
            }

        }
    }
}
