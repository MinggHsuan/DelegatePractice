using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派排序練習
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Village> list = new List<Village>();
            list.Add(new Village(3, "AppleFarm", 32, 5.1));
            list.Add(new Village(1, "BananaFarm", 22, 1.7));
            list.Add(new Village(2, "GuavaFarm", 10, 10.2));
            list.Add(new Village(4, "WatermelonFarm", 15, 6.7));


            Console.WriteLine("ID順序:");
            var IDresult = list.QuickSort((x, y) =>
            {
                return x.ID > y.ID;
            });
            print(IDresult);

            Console.WriteLine("人口順序:");
            var Popresult = list.QuickSort((x, y) =>
            {
                return x.Population > y.Population;
            });
            print(Popresult);

            Console.WriteLine("面積順序:");
            var Arearesult = list.QuickSort((x, y) =>
            {
                return x.Area > y.Area;
            });
            print(Arearesult);



        }


        static void print(List<Village> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.ID}.{item.Name}(人口:{item.Population} 面積:{item.Area})\n");
            }
        }

    }
}
