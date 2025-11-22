using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldReturn練習
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var mail in GetData())
            {
                Console.WriteLine($"- Received: {mail.Title}");
            }
        }
        //static List<Mail> GetData()
        //{
        //    var mailList = new List<Mail>();
        //    int buffer_size = 1024 * 1024 * 4;  // 4MB
        //    Random _rnd = new Random();

        //    for (int index = 0; index < 1024; index++)
        //    {
        //        var _buffer = new byte[buffer_size];
        //        _rnd.NextBytes(_buffer);

        //        mailList.Add(new Mail()
        //        {
        //            Title = $"buffer[{index}], {buffer_size / 1024 / 1024} MB",
        //            Buffer = _buffer,
        //        });
        //        Task.Delay(50).Wait();
        //    }

        //    return mailList;
        //}

        public class Mail
        {
            public string Title { get; set; }
            public byte[] Buffer { get; set; }
        }
        static IEnumerable<Mail> GetData()
        {
            int buffer_size = 1024 * 1024 * 4;  // 4MB
            Random _rnd = new Random();

            for (int index = 0; index < 1024; index++)
            {
                var _buffer = new byte[buffer_size];
                _rnd.NextBytes(_buffer);

                yield return new Mail()
                {
                    Title = $"buffer[{index}], {buffer_size / 1024 / 1024} MB",
                    Buffer = _buffer,
                };
                Task.Delay(50).Wait();
            }

            yield break;
        }
    }
}
