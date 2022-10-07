using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen { color = "Белый", cost = 250 };
        }
    }

    class Pen
    {
        public string color;
        public int cost;
        public Pen()
        {
            color = "Чёрный";
            cost = 100;
        }
        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }
}
