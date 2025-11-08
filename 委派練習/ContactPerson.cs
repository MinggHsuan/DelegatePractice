using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 委派練習
{
    internal class ContactPerson
    {
        public void Contact(string name)
        {
            Console.WriteLine("聯繫中···請稍後···");
            Console.WriteLine("聯繫成功!!!準備發送訊息:");

        }
    }
}
