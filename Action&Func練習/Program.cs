using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Action_Func練習
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 委派: Action/Func/EventHandler/Delegate
            //Action<string> action = SayHello;
            //DoSomething("Leo", x =>
            //{
            //    Console.WriteLine("Hi," + x);
            //    Console.WriteLine("Hello," + x);
            //});

            //ChooseFood("素食", x => Console.WriteLine(x));

            //int[] datas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int[] newarray = Select(datas, x => x * 2);

            //foreach (int i in newarray)
            //{
            //    Console.WriteLine(i);
            //}

            //var newarray2 = Where(datas, x => x % 2 == 0);

            //foreach (int i in newarray2)
            //{
            //    Console.WriteLine(i);
            //}

            //bool isbool = Any(datas, x => x == 2);

            //Console.WriteLine(isbool);


            HttpRequest.Get<List<Article>>(x =>
            {
                foreach (Article article in x)
                {
                    Console.WriteLine(article.body);
                }
            });


            Console.ReadKey();
        }


        static int[] Select(int[] data, Func<int, int> callback)
        {
            int[] newdata = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                newdata[i] = callback.Invoke(data[i]);
            }
            return newdata;
        }
        static List<int> Where(int[] data, Func<int, bool> callback)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < data.Length; i++)
            {
                if (callback.Invoke(data[i]) == true)
                {
                    list.Add(data[i]);
                }
                continue;
            }
            return list;
        }
        static bool Any(int[] data, Func<int, bool> callback)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (callback.Invoke(data[i]) == true)
                {
                    return true;
                }
                continue;
            }
            return false;
        }

        public class Menu
        {
            public string FoodType;
            public string FoodName;

            public Menu(string foodtype, string foodname)
            {
                this.FoodType = foodtype;
                this.FoodName = foodname;
            }
        }

        static void ChooseFood(string foodtype, Action<string> callback)
        {
            List<Menu> list = new List<Menu>();
            list.Add(new Menu("葷食", "滷肉飯"));
            list.Add(new Menu("葷食", "排骨飯"));
            list.Add(new Menu("葷食", "雞腿飯"));
            list.Add(new Menu("素食", "白粥"));
            list.Add(new Menu("素食", "地瓜"));
            list.Add(new Menu("素食", "水煮蛋"));
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].FoodType == foodtype)
                {
                    callback.Invoke(list[i].FoodName);
                }
            }
        }
        static void Calcurate(Func<int, int, int> callback)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());
            int result = callback.Invoke(numberA, numberB);
            Console.WriteLine(result);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }


        static void DoSomething(string name, Action<string> callback)
        {
            for (int i = 0; i < 10; i++)
            {
                callback.Invoke(name);
            }
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hello World:" + name);
        }


    }
}
