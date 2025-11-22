using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派排序練習
{
    internal class Village
    {
        public int ID;
        public string Name;
        public int Population;
        public double Area;

        public Village(int id, string name, int population, double area)
        {
            this.ID = id;
            this.Name = name;
            this.Population = population;
            this.Area = area;
        }
    }
}
